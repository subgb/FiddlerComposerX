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
        }
        

        public void OnBeforeUnload()
        {
        }

    }
}
