using Fiddler;
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

        public ComposerModForm(ComposerMod mod)
        {
            Mod = mod;
            InitializeComponent();
            Left = FiddlerApplication.UI.Right - Width - 20;
            Top = FiddlerApplication.UI.Top + 200;
            Icon = FiddlerApplication.UI.Icon;
        }

        private void ComposerModForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mod.View = null;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var ctx = new RequestContext();
            lbMethod.Text = ctx.Method.Text;
            var uri = new Uri(ctx.Url.Text);
            tbUrl.Text = uri.GetLeftPart(UriPartial.Path);
            tbParamsMod.Text = JoinLines(uri.Query.TrimStart('?').Split('&'));
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

        private string UrlStringify()
        {
            var qs = string.Join("&", DropCommentLines(tbParamsMod.Text));
            if (qs.Length > 0) return tbUrl.Text + "?" + qs;
            return tbUrl.Text;
        }

        private string HeadersStringify()
        {
            var cookies = string.Join("; ", DropCommentLines(tbCookiesMod.Text));
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
    }
}
