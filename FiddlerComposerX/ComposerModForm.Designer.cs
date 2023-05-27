namespace FiddlerComposerX
{
    partial class ComposerModForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImport = new System.Windows.Forms.Button();
            this.lbMethod = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tcRequestMod = new System.Windows.Forms.TabControl();
            this.tabHeadersMod = new System.Windows.Forms.TabPage();
            this.tbHeadersMod = new System.Windows.Forms.TextBox();
            this.tabCookiesMod = new System.Windows.Forms.TabPage();
            this.tbCookiesMod = new System.Windows.Forms.TextBox();
            this.tabParamsMod = new System.Windows.Forms.TabPage();
            this.tbParamsMod = new System.Windows.Forms.TextBox();
            this.tabBodyRawMod = new System.Windows.Forms.TabPage();
            this.tbBodyMod = new System.Windows.Forms.TextBox();
            this.tabBodyFormMod = new System.Windows.Forms.TabPage();
            this.tbFormMod = new System.Windows.Forms.TextBox();
            this.tabBodyJsonMod = new System.Windows.Forms.TabPage();
            this.tbJsonMod = new System.Windows.Forms.TextBox();
            this.tcRequestMod.SuspendLayout();
            this.tabHeadersMod.SuspendLayout();
            this.tabCookiesMod.SuspendLayout();
            this.tabParamsMod.SuspendLayout();
            this.tabBodyRawMod.SuspendLayout();
            this.tabBodyFormMod.SuspendLayout();
            this.tabBodyJsonMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(16, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lbMethod
            // 
            this.lbMethod.AutoSize = true;
            this.lbMethod.Location = new System.Drawing.Point(116, 18);
            this.lbMethod.Name = "lbMethod";
            this.lbMethod.Size = new System.Drawing.Size(0, 12);
            this.lbMethod.TabIndex = 1;
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(16, 49);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(556, 21);
            this.tbUrl.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(497, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tcRequestMod
            // 
            this.tcRequestMod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcRequestMod.Controls.Add(this.tabHeadersMod);
            this.tcRequestMod.Controls.Add(this.tabCookiesMod);
            this.tcRequestMod.Controls.Add(this.tabParamsMod);
            this.tcRequestMod.Controls.Add(this.tabBodyRawMod);
            this.tcRequestMod.Controls.Add(this.tabBodyFormMod);
            this.tcRequestMod.Controls.Add(this.tabBodyJsonMod);
            this.tcRequestMod.Location = new System.Drawing.Point(12, 87);
            this.tcRequestMod.Name = "tcRequestMod";
            this.tcRequestMod.SelectedIndex = 0;
            this.tcRequestMod.Size = new System.Drawing.Size(560, 362);
            this.tcRequestMod.TabIndex = 4;
            this.tcRequestMod.SelectedIndexChanged += new System.EventHandler(this.tcRequestMod_SelectedIndexChanged);
            this.tcRequestMod.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcRequestMod_Selected);
            this.tcRequestMod.Deselected += new System.Windows.Forms.TabControlEventHandler(this.tcRequestMod_Deselected);
            // 
            // tabHeadersMod
            // 
            this.tabHeadersMod.Controls.Add(this.tbHeadersMod);
            this.tabHeadersMod.Location = new System.Drawing.Point(4, 22);
            this.tabHeadersMod.Name = "tabHeadersMod";
            this.tabHeadersMod.Size = new System.Drawing.Size(552, 336);
            this.tabHeadersMod.TabIndex = 0;
            this.tabHeadersMod.Text = "Headers";
            this.tabHeadersMod.UseVisualStyleBackColor = true;
            // 
            // tbHeadersMod
            // 
            this.tbHeadersMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHeadersMod.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHeadersMod.Location = new System.Drawing.Point(0, 0);
            this.tbHeadersMod.Multiline = true;
            this.tbHeadersMod.Name = "tbHeadersMod";
            this.tbHeadersMod.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbHeadersMod.Size = new System.Drawing.Size(552, 336);
            this.tbHeadersMod.TabIndex = 0;
            this.tbHeadersMod.WordWrap = false;
            // 
            // tabCookiesMod
            // 
            this.tabCookiesMod.Controls.Add(this.tbCookiesMod);
            this.tabCookiesMod.Location = new System.Drawing.Point(4, 22);
            this.tabCookiesMod.Name = "tabCookiesMod";
            this.tabCookiesMod.Size = new System.Drawing.Size(552, 336);
            this.tabCookiesMod.TabIndex = 2;
            this.tabCookiesMod.Text = "Cookies";
            this.tabCookiesMod.UseVisualStyleBackColor = true;
            // 
            // tbCookiesMod
            // 
            this.tbCookiesMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCookiesMod.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCookiesMod.Location = new System.Drawing.Point(0, 0);
            this.tbCookiesMod.Multiline = true;
            this.tbCookiesMod.Name = "tbCookiesMod";
            this.tbCookiesMod.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCookiesMod.Size = new System.Drawing.Size(552, 336);
            this.tbCookiesMod.TabIndex = 1;
            this.tbCookiesMod.WordWrap = false;
            // 
            // tabParamsMod
            // 
            this.tabParamsMod.Controls.Add(this.tbParamsMod);
            this.tabParamsMod.Location = new System.Drawing.Point(4, 22);
            this.tabParamsMod.Name = "tabParamsMod";
            this.tabParamsMod.Size = new System.Drawing.Size(552, 336);
            this.tabParamsMod.TabIndex = 1;
            this.tabParamsMod.Text = "Params";
            this.tabParamsMod.UseVisualStyleBackColor = true;
            // 
            // tbParamsMod
            // 
            this.tbParamsMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbParamsMod.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbParamsMod.Location = new System.Drawing.Point(0, 0);
            this.tbParamsMod.Multiline = true;
            this.tbParamsMod.Name = "tbParamsMod";
            this.tbParamsMod.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbParamsMod.Size = new System.Drawing.Size(552, 336);
            this.tbParamsMod.TabIndex = 2;
            this.tbParamsMod.WordWrap = false;
            // 
            // tabBodyRawMod
            // 
            this.tabBodyRawMod.Controls.Add(this.tbBodyMod);
            this.tabBodyRawMod.Location = new System.Drawing.Point(4, 22);
            this.tabBodyRawMod.Name = "tabBodyRawMod";
            this.tabBodyRawMod.Size = new System.Drawing.Size(552, 336);
            this.tabBodyRawMod.TabIndex = 3;
            this.tabBodyRawMod.Text = "Body";
            this.tabBodyRawMod.UseVisualStyleBackColor = true;
            // 
            // tbBodyMod
            // 
            this.tbBodyMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBodyMod.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbBodyMod.Location = new System.Drawing.Point(0, 0);
            this.tbBodyMod.Multiline = true;
            this.tbBodyMod.Name = "tbBodyMod";
            this.tbBodyMod.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbBodyMod.Size = new System.Drawing.Size(552, 336);
            this.tbBodyMod.TabIndex = 1;
            this.tbBodyMod.WordWrap = false;
            // 
            // tabBodyFormMod
            // 
            this.tabBodyFormMod.Controls.Add(this.tbFormMod);
            this.tabBodyFormMod.Location = new System.Drawing.Point(4, 22);
            this.tabBodyFormMod.Name = "tabBodyFormMod";
            this.tabBodyFormMod.Size = new System.Drawing.Size(552, 336);
            this.tabBodyFormMod.TabIndex = 4;
            this.tabBodyFormMod.Text = "Form";
            this.tabBodyFormMod.UseVisualStyleBackColor = true;
            // 
            // tbFormMod
            // 
            this.tbFormMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFormMod.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFormMod.Location = new System.Drawing.Point(0, 0);
            this.tbFormMod.Multiline = true;
            this.tbFormMod.Name = "tbFormMod";
            this.tbFormMod.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbFormMod.Size = new System.Drawing.Size(552, 336);
            this.tbFormMod.TabIndex = 1;
            this.tbFormMod.WordWrap = false;
            // 
            // tabBodyJsonMod
            // 
            this.tabBodyJsonMod.Controls.Add(this.tbJsonMod);
            this.tabBodyJsonMod.Location = new System.Drawing.Point(4, 22);
            this.tabBodyJsonMod.Name = "tabBodyJsonMod";
            this.tabBodyJsonMod.Size = new System.Drawing.Size(552, 336);
            this.tabBodyJsonMod.TabIndex = 5;
            this.tabBodyJsonMod.Text = "JSON";
            this.tabBodyJsonMod.UseVisualStyleBackColor = true;
            // 
            // tbJsonMod
            // 
            this.tbJsonMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbJsonMod.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbJsonMod.Location = new System.Drawing.Point(0, 0);
            this.tbJsonMod.Multiline = true;
            this.tbJsonMod.Name = "tbJsonMod";
            this.tbJsonMod.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbJsonMod.Size = new System.Drawing.Size(552, 336);
            this.tbJsonMod.TabIndex = 1;
            this.tbJsonMod.WordWrap = false;
            // 
            // ComposerModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tcRequestMod);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.lbMethod);
            this.Controls.Add(this.btnImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ComposerModForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ComposerX Mod";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComposerModForm_FormClosing);
            this.tcRequestMod.ResumeLayout(false);
            this.tabHeadersMod.ResumeLayout(false);
            this.tabHeadersMod.PerformLayout();
            this.tabCookiesMod.ResumeLayout(false);
            this.tabCookiesMod.PerformLayout();
            this.tabParamsMod.ResumeLayout(false);
            this.tabParamsMod.PerformLayout();
            this.tabBodyRawMod.ResumeLayout(false);
            this.tabBodyRawMod.PerformLayout();
            this.tabBodyFormMod.ResumeLayout(false);
            this.tabBodyFormMod.PerformLayout();
            this.tabBodyJsonMod.ResumeLayout(false);
            this.tabBodyJsonMod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lbMethod;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabControl tcRequestMod;
        private System.Windows.Forms.TabPage tabHeadersMod;
        private System.Windows.Forms.TabPage tabParamsMod;
        private System.Windows.Forms.TabPage tabCookiesMod;
        private System.Windows.Forms.TabPage tabBodyRawMod;
        private System.Windows.Forms.TabPage tabBodyFormMod;
        private System.Windows.Forms.TabPage tabBodyJsonMod;
        private System.Windows.Forms.TextBox tbHeadersMod;
        private System.Windows.Forms.TextBox tbCookiesMod;
        private System.Windows.Forms.TextBox tbBodyMod;
        private System.Windows.Forms.TextBox tbFormMod;
        private System.Windows.Forms.TextBox tbJsonMod;
        private System.Windows.Forms.TextBox tbParamsMod;
    }
}