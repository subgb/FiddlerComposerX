using Fiddler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiddlerComposerX
{
    public class CopyCurl : IFiddlerExtension
    {
        MenuItem mnuCurl;
        public void OnLoad()
        {
            mnuCurl = new MenuItem("Copy as cURL Script");
            mnuCurl.Click += MnuCurl_Click; ;
            FiddlerApplication.UI.mnuSessionContext.MenuItems.Add(mnuCurl);
            FiddlerApplication.UI.mnuSessionContext.Popup += MnuSessionContext_Popup;
        }

        private void MnuCurl_Click(object sender, EventArgs e)
        {
            var list = FiddlerApplication.UI.GetSelectedSessions();
            if (list.Length != 1) return;
            var format = "cURL Script";
            var file = $"{CONFIG.GetPath("SafeTemp")}curl_{list[0].id}.txt";
            Utilities.EnsureOverwritable(file);
            FiddlerApplication.LogLeakedFile(file);
            var opt = new Dictionary<string, object>()
            {
                {"Filename", file},
            };
            var exporter = FiddlerApplication.oTranscoders.GetExporter(format);
            try
            {
                var obj = (ISessionExporter)Activator.CreateInstance(exporter.typeFormatter);
                obj.ExportSessions(format, list, opt, null);
                obj.Dispose();
                var cmd = PrettyCurlCommand(File.ReadAllText(file));
                Utilities.CopyToClipboard(cmd);
                FiddlerObject.StatusText = $"Copy to clipboard successful!";
            }
            catch
            {
                FiddlerObject.StatusText = $"Fails to copy cURL script!!!";
            }
        }

        private string PrettyCurlCommand(string cmd)
        {
            cmd = Utils.ReplaceFirst(cmd, " -o 0.dat ", " ").Replace("\" -H \"", "\" \\\n  -H \"");
            var pattern = @"^  -H ""Accept-Encoding:.+"" \\\n";
            cmd = Regex.Replace(cmd, pattern, string.Empty, RegexOptions.IgnoreCase | RegexOptions.Multiline);
            return cmd;
        }

        private void MnuSessionContext_Popup(object sender, EventArgs e)
        {
            var len = FiddlerApplication.UI.GetSelectedSessions().Length;
            mnuCurl.Enabled = len == 1;
        }

        public void OnBeforeUnload()
        {
        }
    }
}
