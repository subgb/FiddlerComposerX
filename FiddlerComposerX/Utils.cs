﻿using Fiddler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiddlerComposerX
{
    public static class Utils
    {
        public static void TraverseControls(Control control, string prefix = "###")
        {
            if (control == null) return;
            foreach (Control child in control.Controls)
            {
                string name = child.Name == "" ? "\"\"" : child.Name;
                string path = $"{prefix}->{name}";
                FiddlerApplication.Log.LogString($"{path} := {child.Text}");
                if (child.HasChildren)
                {
                    TraverseControls(child, path);
                }
            }
        }

        public static Control FindSubControl(Control control, string name)
        {
            if (control == null) return null;
            foreach (Control child in control.Controls)
            {
                if (child.Name == name) return child;
                if (child.HasChildren)
                {
                    var found = FindSubControl(child, name);
                    if (found != null) return found;
                }
            }
            return null;
        }

        public static void KeepTextBoxPosition(TextBox tb, Action changer)
        {
            var fi = tb.GetCharIndexFromPosition(new Point(1, 5));
            var li = tb.GetCharIndexFromPosition(new Point(1, tb.ClientSize.Height - 6));
            var fl = tb.GetLineFromCharIndex(fi);
            var ll = tb.GetLineFromCharIndex(li);
            changer();
            fi = tb.GetFirstCharIndexFromLine(fl);
            tb.Select(li, 0);
            tb.ScrollToCaret();
            li = tb.GetFirstCharIndexFromLine(ll);
            tb.Select(fi, 0);
            tb.ScrollToCaret();
        }

        public static string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0) return text;
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }

    public class RequestContext
    {
        private static Control View;

        public Control Url { get; set; }
        public Control Method { get; set; }
        public Control Headers { get; set; }
        public Control Body { get; set; }
        public TabControl Tabs { get; set; }

        public RequestContext()
        {
            var ui = FiddlerApplication.UI;
            var page = ui.pageBuilder;
            if (ui.tabsViews.TabPages.Contains(page))
            {
                ui.tabsViews.SelectTab(page);
                View = Utils.FindSubControl(page, "UIComposer");
            }
            if (View == null) return;
            Tabs = (TabControl)Utils.FindSubControl(View, "tabsBuilder");
            var panel = Utils.FindSubControl(Tabs, "pnlParsed");
            Url = Utils.FindSubControl(panel, "cbxBuilderURL");
            Method = Utils.FindSubControl(panel, "cbxBuilderMethod");
            Headers = Utils.FindSubControl(panel, "txtBuilderRequestHeaders");
            Body = Utils.FindSubControl(panel, "txtBuilderRequestBody");
        }

        public void Send()
        {
            Tabs.SelectedIndex = 0;
            var btn = (Button)Utils.FindSubControl(View, "btnBuilderExecute");
            btn.PerformClick();
        }
    }
        
}
