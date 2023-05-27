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

        public void OnLoad()
        {
            var btn = new ToolStripButton();
            btn.ToolTipText = "Popup The ComposerX Mod";
            btn.ImageIndex = 35;
            btn.Text = "ComposerX";
            btn.Click += delegate
            {
                if (View==null) {
                    View = new ComposerModForm(this);
                    View.Show(FiddlerApplication.UI);
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
