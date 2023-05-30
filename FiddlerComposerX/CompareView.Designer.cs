namespace FiddlerComposerX
{
    partial class CompareView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbLeft = new System.Windows.Forms.Label();
            this.lbRight = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.cbQeury = new System.Windows.Forms.CheckBox();
            this.cbCookie = new System.Windows.Forms.CheckBox();
            this.cbForm = new System.Windows.Forms.CheckBox();
            this.cbReqJson = new System.Windows.Forms.CheckBox();
            this.cbRespJson = new System.Windows.Forms.CheckBox();
            this.cbResp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLeft
            // 
            this.tbLeft.AllowDrop = true;
            this.tbLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLeft.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLeft.Location = new System.Drawing.Point(0, 24);
            this.tbLeft.Multiline = true;
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.ReadOnly = true;
            this.tbLeft.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLeft.Size = new System.Drawing.Size(280, 482);
            this.tbLeft.TabIndex = 0;
            this.tbLeft.WordWrap = false;
            this.tbLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.tbLeft.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_DragEnter);
            // 
            // tbRight
            // 
            this.tbRight.AllowDrop = true;
            this.tbRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRight.Location = new System.Drawing.Point(0, 24);
            this.tbRight.Multiline = true;
            this.tbRight.Name = "tbRight";
            this.tbRight.ReadOnly = true;
            this.tbRight.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbRight.Size = new System.Drawing.Size(275, 482);
            this.tbRight.TabIndex = 1;
            this.tbRight.WordWrap = false;
            this.tbRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.tbRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_DragEnter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 54);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbLeft);
            this.splitContainer1.Panel1.Controls.Add(this.tbLeft);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbRight);
            this.splitContainer1.Panel2.Controls.Add(this.tbRight);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(559, 506);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 2;
            // 
            // lbLeft
            // 
            this.lbLeft.AutoSize = true;
            this.lbLeft.Location = new System.Drawing.Point(16, 6);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(0, 12);
            this.lbLeft.TabIndex = 1;
            // 
            // lbRight
            // 
            this.lbRight.AutoSize = true;
            this.lbRight.Location = new System.Drawing.Point(16, 6);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(0, 12);
            this.lbRight.TabIndex = 2;
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.Location = new System.Drawing.Point(459, 15);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // cbQeury
            // 
            this.cbQeury.AutoSize = true;
            this.cbQeury.Checked = true;
            this.cbQeury.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbQeury.Location = new System.Drawing.Point(4, 9);
            this.cbQeury.Name = "cbQeury";
            this.cbQeury.Size = new System.Drawing.Size(126, 16);
            this.cbQeury.TabIndex = 4;
            this.cbQeury.Text = "Parse QueryString";
            this.cbQeury.UseVisualStyleBackColor = true;
            this.cbQeury.CheckedChanged += new System.EventHandler(this.cbQeury_CheckedChanged);
            // 
            // cbCookie
            // 
            this.cbCookie.AutoSize = true;
            this.cbCookie.Checked = true;
            this.cbCookie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCookie.Location = new System.Drawing.Point(4, 32);
            this.cbCookie.Name = "cbCookie";
            this.cbCookie.Size = new System.Drawing.Size(96, 16);
            this.cbCookie.TabIndex = 5;
            this.cbCookie.Text = "Parse Cookie";
            this.cbCookie.UseVisualStyleBackColor = true;
            this.cbCookie.CheckedChanged += new System.EventHandler(this.cbCookie_CheckedChanged);
            // 
            // cbForm
            // 
            this.cbForm.AutoSize = true;
            this.cbForm.Location = new System.Drawing.Point(140, 9);
            this.cbForm.Name = "cbForm";
            this.cbForm.Size = new System.Drawing.Size(144, 16);
            this.cbForm.TabIndex = 6;
            this.cbForm.Text = "Request Body as Form";
            this.cbForm.UseVisualStyleBackColor = true;
            this.cbForm.CheckedChanged += new System.EventHandler(this.cbForm_CheckedChanged);
            // 
            // cbReqJson
            // 
            this.cbReqJson.AutoSize = true;
            this.cbReqJson.Location = new System.Drawing.Point(140, 31);
            this.cbReqJson.Name = "cbReqJson";
            this.cbReqJson.Size = new System.Drawing.Size(144, 16);
            this.cbReqJson.TabIndex = 7;
            this.cbReqJson.Text = "Request Body as JSON";
            this.cbReqJson.UseVisualStyleBackColor = true;
            this.cbReqJson.CheckedChanged += new System.EventHandler(this.cbReqJson_CheckedChanged);
            // 
            // cbRespJson
            // 
            this.cbRespJson.AutoSize = true;
            this.cbRespJson.Location = new System.Drawing.Point(298, 31);
            this.cbRespJson.Name = "cbRespJson";
            this.cbRespJson.Size = new System.Drawing.Size(150, 16);
            this.cbRespJson.TabIndex = 8;
            this.cbRespJson.Text = "Response Body as JSON";
            this.cbRespJson.UseVisualStyleBackColor = true;
            this.cbRespJson.CheckedChanged += new System.EventHandler(this.cbRespJson_CheckedChanged);
            // 
            // cbResp
            // 
            this.cbResp.AutoSize = true;
            this.cbResp.Checked = true;
            this.cbResp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbResp.Location = new System.Drawing.Point(298, 9);
            this.cbResp.Name = "cbResp";
            this.cbResp.Size = new System.Drawing.Size(150, 16);
            this.cbResp.TabIndex = 9;
            this.cbResp.Text = "Contain Response Body";
            this.cbResp.UseVisualStyleBackColor = true;
            this.cbResp.CheckedChanged += new System.EventHandler(this.cbResp_CheckedChanged);
            // 
            // CompareView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.cbResp);
            this.Controls.Add(this.cbRespJson);
            this.Controls.Add(this.cbReqJson);
            this.Controls.Add(this.cbForm);
            this.Controls.Add(this.cbCookie);
            this.Controls.Add(this.cbQeury);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CompareView";
            this.Size = new System.Drawing.Size(588, 579);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLeft;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbLeft;
        private System.Windows.Forms.Label lbRight;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.CheckBox cbQeury;
        private System.Windows.Forms.CheckBox cbCookie;
        private System.Windows.Forms.CheckBox cbForm;
        private System.Windows.Forms.CheckBox cbReqJson;
        private System.Windows.Forms.CheckBox cbRespJson;
        private System.Windows.Forms.CheckBox cbResp;
    }
}
