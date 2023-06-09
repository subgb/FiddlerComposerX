using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiddler;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FiddlerComposerX
{
    public partial class CompareView : UserControl
    {
        public CompareView()
        {
            InitializeComponent();
            lbLeft.Tag = tbLeft;
            lbRight.Tag = tbRight;
        }
        
        private void textBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Fiddler.Session[]"))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Fiddler.Session[]"))
            {
                try
                {
                    var textBox = sender as TextBox;
                    var array = (Session[])e.Data.GetData("Fiddler.Session[]");
                    if (array.Length==2)
                    {
                        tbLeft.Text = PrettySession(array[0]);
                        tbLeft.Tag = array[0];
                        tbRight.Text = PrettySession(array[1]);
                        tbRight.Tag = array[1];
                    }
                    else
                    {
                        textBox.Text = PrettySession(array[0]);
                        textBox.Tag = array[0];
                    }
                    if (tbLeft.Tag != null) lbLeft.Text = "#" + (tbLeft.Tag as Session).id;
                    if (tbRight.Tag != null) lbRight.Text = "#" + (tbRight.Tag as Session).id;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fiddler is unable to accept drops from other processes.\n\n" + ex.Message, "Operation failed");
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private string PrettySession(Session session)
        {
            var parseQuery = cbQeury.Checked;
            var parseCookie = cbCookie.Checked;
            var reqForm = cbForm.Checked;
            var reqJson = cbReqJson.Checked;
            var containResp = cbResp.Checked;
            var respJson = cbRespJson.Checked;

            StringBuilder sb = new StringBuilder(1024);
            sb.AppendLine("---- REQUEST ----------------------------------------------");
            var httpver = session.oRequest.headers.HTTPVersion;
            if (parseQuery)
            {
                sb.AppendLine(session.RequestMethod);
                var uri = new Uri(session.fullUrl);
                var path = uri.GetLeftPart(UriPartial.Path);
                var query = uri.Query.Replace("&", "\r\n\t&");
                sb.AppendLine(path);
                if (query != "") sb.AppendLine("\t" + query);
                sb.AppendLine(httpver);
            }
            else
            {
                sb.AppendLine($"{session.RequestMethod} {session.fullUrl} {httpver}");
            }
            sb.AppendLine();

            sb.AppendLine("---- REQUEST HEADERS --------------------------------------");
            var headers = session.oRequest.headers.ToArray();
            foreach(var item in headers)
            {
                if (parseCookie && item.Name.Equals("Cookie", StringComparison.OrdinalIgnoreCase))
                {
                    sb.AppendLine("Cookie:");
                    var cookie = item.Value.Replace("; ", ";\r\n\t");
                    sb.AppendLine("\t" + cookie);
                }
                else
                {
                    sb.AppendLine($"{item.Name}: {item.Value}");
                }
            }
            sb.AppendLine();

            sb.AppendLine("---- REQUEST BODY ------------------------------------------");
            if (session.RequestBody.Length > 0)
            {
                var body = session.GetRequestBodyAsString();
                if (reqForm)
                {
                    body = body.Replace("&", "&\r\n");
                }
                else if (reqJson)
                {
                    try
                    {
                        body = JToken.Parse(body).ToString(Formatting.Indented);
                    }
                    catch {}
                }
                sb.AppendLine(body);
            }
            sb.AppendLine();

            sb.AppendLine("---- RESPONSE ----------------------------------------------");
            sb.AppendLine($"{session.oResponse.headers.HTTPVersion} {session.oResponse.headers.HTTPResponseStatus}");
            sb.AppendLine();

            sb.AppendLine("---- RESPONSE HEADERS --------------------------------------");
            headers = session.oResponse.headers.ToArray();
            foreach (var item in headers)
            {
                sb.AppendLine($"{item.Name}: {item.Value}");
            }
            sb.AppendLine();

            sb.AppendLine("---- RESPONSE BODY -----------------------------------------");
            if (session.ResponseBody.Length > 0 && containResp)
            {
                var body = session.GetResponseBodyAsString();
                if (respJson)
                {
                    try
                    {
                        body = JToken.Parse(body).ToString(Formatting.Indented);
                    }
                    catch { }
                }
                sb.AppendLine(body);
            }

            return sb.ToString();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            var f1 = SaveToFile(tbLeft);
            if (f1 == null)
            {
                FiddlerObject.alert("Please drag & drop a session onto the left panel below.");
                return;
            }
            var f2 = SaveToFile(tbRight);
            if (f2 == null)
            {
                FiddlerObject.alert("Please drag & drop a session onto the right panel below.");
                return;
            };
            var prefs = FiddlerApplication.Prefs;
            string format = ((ModifierKeys == Keys.Shift || ModifierKeys == Keys.Alt) ? prefs.GetStringPref("fiddler.differ.ParamsAlt", "\"{0}\" \"{1}\" -p") : prefs.GetStringPref("fiddler.differ.Params", " \"{0}\" \"{1}\""));
            using (Process.Start(CONFIG.GetPath("WINDIFF"), string.Format(format, f1, f2))){}
        }

        private string SaveToFile(TextBox textBox)
        {
            var path = CONFIG.GetPath("SafeTemp");
            var session = textBox.Tag as Session;
            if (session == null) return null;
            var file = $"{path}left_{session.id}.txt";
            Utilities.EnsureOverwritable(file);
            FiddlerApplication.LogLeakedFile(file);
            File.WriteAllText(file, textBox.Text);
            return file;
        }

        private void UpdateContent()
        {
            if (tbLeft.Tag != null) tbLeft.Text = PrettySession((Session)tbLeft.Tag);
            if (tbRight.Tag != null) tbRight.Text = PrettySession((Session)tbRight.Tag);
        }

        private void cbQeury_CheckedChanged(object sender, EventArgs e)
        {
            UpdateContent();
        }

        private void cbCookie_CheckedChanged(object sender, EventArgs e)
        {
            UpdateContent();
        }

        private void cbForm_CheckedChanged(object sender, EventArgs e)
        {
            if (cbForm.Checked) cbReqJson.Checked = false;
            UpdateContent();
        }

        private void cbReqJson_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReqJson.Checked) cbForm.Checked = false;
            UpdateContent();
        }

        private void cbRespJson_CheckedChanged(object sender, EventArgs e)
        {
            UpdateContent();
        }

        private void cbResp_CheckedChanged(object sender, EventArgs e)
        {
            cbRespJson.Enabled = cbResp.Checked;
            UpdateContent();
        }

        private void label_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            var textBox = label.Tag as TextBox;
            var session = textBox.Tag as Session;
            if (session == null) return;
            var vi = session.ViewItem;
            if (vi.ListView == null)
            {
                FiddlerObject.StatusText = $"Can't reveal {label.Text} in session list";
                return;
            };
            foreach (ListViewItem i in vi.ListView.SelectedItems)
            {
                i.Selected = false;
            }
            vi.Selected = true;
            vi.Focused = true;
            vi.EnsureVisible();
        }
    }
}
