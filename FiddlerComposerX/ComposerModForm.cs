using Fiddler;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FiddlerComposerX
{
    public partial class ComposerModForm : Form
    {
        private ComposerMod Mod;
        private string InitForm;
        private string LastForm = "";
        private string InitJson;

        public ComposerModForm(ComposerMod mod)
        {
            Mod = mod;
            InitializeComponent();
            var ui = FiddlerApplication.UI;
            Left = ui.Right - Width - 20;
            Top = ui.Top + 200;
            Icon = ui.Icon;
            tcRequestMod.ImageList = ui.tabsViews.ImageList;
        }

        private void ComposerModForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mod.View = null;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var ctx = new RequestContext();
            lbMethod.Text = ctx.Method.Text;
            try
            {
                var uri = new Uri(ctx.Url.Text);
                tbUrl.Text = uri.GetLeftPart(UriPartial.Path);
                tbParamsMod.Text = JoinLines(uri.Query.TrimStart('?').Split('&'));
            }
            catch
            {
                tbUrl.Text = "";
                tbParamsMod.Text = "";
            }
            tbHeadersMod.Text = ctx.Headers.Text;
            tbCookiesMod.Text = ParseHeadersCookie(ctx.Headers.Text);
            tbBodyMod.Text = ctx.Body.Text;
            LastForm = "";
            onSelectedTab(tcRequestMod.SelectedTab.Name);
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            onDeselectedTab(tcRequestMod.SelectedTab.Name);
            InitForm = tbFormMod.Text;
            InitJson = tbJsonMod.Text;
            var ctx = new RequestContext();
            lbMethod.Text = ctx.Method.Text;
            ctx.Url.Text = UrlStringify();
            ctx.Headers.Text = HeadersStringify();
            ctx.Body.Text = tbBodyMod.Text;
            ctx.Send();
        }

        private void onSelectedTab(string name)
        {
            if (name == "tabBodyFormMod")
            {
                var lastParsed = JoinLines(DropCommentLines(LastForm));
                var newParsed = JoinLines(tbBodyMod.Text.Split('&'));
                tbFormMod.Text = InitForm = lastParsed == newParsed ? LastForm : newParsed;
            }
            else if (name == "tabBodyJsonMod")
            {
                tbJsonMod.Text = InitJson = ConvertJson(tbBodyMod.Text, true);
            }
        }

        private void onDeselectedTab(string name)
        {
            if (name == "tabBodyFormMod")
            {
                LastForm = tbFormMod.Text;
                if (tbFormMod.Text != InitForm)
                {
                    tbBodyMod.Text = string.Join("&", DropCommentLines(tbFormMod.Text));
                }
            }
            else if (name == "tabBodyJsonMod")
            {
                if (tbJsonMod.Text != InitJson)
                {
                    tbBodyMod.Text = ConvertJson(tbJsonMod.Text);
                }
            }
        }

        private void tcRequestMod_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tcRequestMod_Selected(object sender, TabControlEventArgs e)
        {
            onSelectedTab(e.TabPage.Name);
        }

        private void tcRequestMod_Deselected(object sender, TabControlEventArgs e)
        {
            onDeselectedTab(e.TabPage.Name);
        }

        private string ParseHeadersCookie(string headers)
        {
            string cookie = headers.Split('\n').FirstOrDefault(line => line.Trim().StartsWith("Cookie:", StringComparison.OrdinalIgnoreCase));
            return cookie == null ? "" : JoinLines(cookie.Trim().Substring(7).Trim().Split(';'));
        }

        private string ConvertJson(string input, bool pretty = false)
        {
            if (input.Trim() == "") return input;
            try
            {
                var fmt = pretty ? Formatting.Indented : Formatting.None;
                var text =  JToken.Parse(input).ToString(fmt);
                tabBodyJsonMod.ImageKey = "";
                return text;
            }
            catch (JsonReaderException ex)
            {
                tabBodyJsonMod.ImageKey = "Error";
                MessageBox.Show(ex.Message, "Parse JSON Error");
                return input;
            }
        }

        private string UrlStringify()
        {
            var qs = string.Join("&", DropCommentLines(tbParamsMod.Text).Select(x => x.Trim('&')));
            if (qs.Length > 0) return tbUrl.Text + "?" + qs;
            return tbUrl.Text;
        }

        private string HeadersStringify()
        {
            var cookies = string.Join("; ", DropCommentLines(tbCookiesMod.Text).Select(x => x.TrimEnd(';')));
            var lines = DropCommentLines(tbHeadersMod.Text).Select(line =>
            {
                if (!line.StartsWith("Cookie:", StringComparison.OrdinalIgnoreCase)) return line;
                if (cookies.Length > 0) return "Cookie: " + cookies;
                return "";
            }).Where(x => x.Length > 0);
            return JoinLines(lines);
        }

        private string[] DropCommentLines(string input)
        {
            return input.Split('\n').Select(x => x.Trim()).Where(x => x.Length > 0).Where(x => !x.StartsWith("//")).ToArray();
        }

        private string JoinLines(IEnumerable<string> lines)
        {
            var text = string.Join("\r\n", lines.Select(x => x.Trim()));
            if (text.Length>0) text += "\r\n";
            return text;
        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            var tb = (TextBox)sender;
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                var lines = tb.Lines;
                if (lines.Length <= 0) return;
                var index = tb.GetCharIndexFromPosition(e.Location);
                var line = tb.GetLineFromCharIndex(index);
                var text = lines[line].Trim();
                if (text != "")
                {
                    var isComment = text.StartsWith("//");
                    lines[line] = isComment ? text.TrimStart('/').TrimStart() : "// " + text;
                    Utils.KeepTextBoxPosition(tb, () => tb.Lines = lines);
                    index = tb.GetFirstCharIndexFromLine(line);
                    tb.Select(index, isComment ? 0 : 3);
                }
            }
        }
    }
}
