using Fiddler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiddlerComposerX
{
    public class ComposerMod : IFiddlerExtension
    {
        public ComposerModForm View { get; set; }
        readonly string ModName = "ComposerX";

        public void OnLoad()
        {
            var ui = FiddlerApplication.UI;
            var icon = ui.tabsViews.ImageList.Images["compose"];
            ui.imglToolbar.Images.Add(ModName, icon);

            var btn = new ToolStripButton();
            btn.ToolTipText = "Popup The ComposerX Mod";
            btn.ImageKey = ModName;
            btn.Text = ModName;
            btn.Click += delegate
            {
                if (View==null) {
                    View = new ComposerModForm(this);
                    View.Show(ui);
                }
                else
                {
                    View.BringToFront();
                }
            };
            FiddlerToolbar.AddToolStripItem(btn);
            ui.lvSessions.ItemSelectionChanged += SelectedSessionChanged;
        }

        private void SelectedSessionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var ui = FiddlerApplication.UI;
            var lv = (ListView)sender;
            if (lv.SelectedIndices.Count != 1) return;
            var sess = ui.GetFirstSelectedSession();
            var size = sess.ResponseBody.Length;
            if (size < 300e3) return;
            var page = ui.pageInspector;
            if (ui.tabsViews.SelectedTab != page) return;
            var resp = (TabControl)Utils.FindSubControl(page, "tabsResponse");
            var tab = resp.SelectedTab.Text;
            if ((tab == "Raw" || tab == "TextView" || tab == "SyntaxView")) resp.SelectTab(1);
        }

        public void OnBeforeUnload()
        {
        }

    }
}
