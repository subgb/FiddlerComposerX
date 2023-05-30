using Fiddler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiddlerComposerX
{

    public class PrettyCompare : IFiddlerExtension
    {
        private TabPage oPage;
        private CompareView oView;

        public void OnLoad()
        {
            oPage = new TabPage("Compare");
            oView = new CompareView();
            oPage.Controls.Add(oView);
            oView.Dock = DockStyle.Fill;
            FiddlerApplication.UI.tabsViews.TabPages.Add(oPage);
        }

        public void OnBeforeUnload()
        {
        }
    }
}
