
namespace StartWeChat
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.tbPath = new System.Windows.Forms.TextBox();
            this.softPathLb = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.nubLb = new System.Windows.Forms.Label();
            this.chbCloseSelf = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPath.Location = new System.Drawing.Point(134, 61);
            this.tbPath.Margin = new System.Windows.Forms.Padding(5);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(553, 30);
            this.tbPath.TabIndex = 0;
            // 
            // softPathLb
            // 
            this.softPathLb.AutoSize = true;
            this.softPathLb.Location = new System.Drawing.Point(46, 64);
            this.softPathLb.Name = "softPathLb";
            this.softPathLb.Size = new System.Drawing.Size(82, 24);
            this.softPathLb.TabIndex = 1;
            this.softPathLb.Text = "微信路径";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(220, 213);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(237, 48);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // nud
            // 
            this.nud.AutoSize = true;
            this.nud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud.Location = new System.Drawing.Point(134, 122);
            this.nud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(180, 30);
            this.nud.TabIndex = 3;
            this.nud.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nubLb
            // 
            this.nubLb.AutoSize = true;
            this.nubLb.Location = new System.Drawing.Point(46, 124);
            this.nubLb.Name = "nubLb";
            this.nubLb.Size = new System.Drawing.Size(82, 24);
            this.nubLb.TabIndex = 1;
            this.nubLb.Text = "启动个数";
            // 
            // chbCloseSelf
            // 
            this.chbCloseSelf.AutoSize = true;
            this.chbCloseSelf.Checked = true;
            this.chbCloseSelf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCloseSelf.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.chbCloseSelf.Location = new System.Drawing.Point(230, 273);
            this.chbCloseSelf.Name = "chbCloseSelf";
            this.chbCloseSelf.Size = new System.Drawing.Size(216, 28);
            this.chbCloseSelf.TabIndex = 4;
            this.chbCloseSelf.Text = "启动微信后关闭本窗口";
            this.chbCloseSelf.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 354);
            this.Controls.Add(this.chbCloseSelf);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nubLb);
            this.Controls.Add(this.softPathLb);
            this.Controls.Add(this.tbPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartWeChat";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label softPathLb;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Label nubLb;
        private System.Windows.Forms.CheckBox chbCloseSelf;
    }
}

