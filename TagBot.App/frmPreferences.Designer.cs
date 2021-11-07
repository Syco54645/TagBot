
namespace TagBot.App
{
    partial class frmPreferences
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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAlbumFormatter = new System.Windows.Forms.TextBox();
            this.grpAlbumFormatter = new System.Windows.Forms.GroupBox();
            this.lblAlbumFormatterDemo = new System.Windows.Forms.Label();
            this.txtCustomDateFormatter = new System.Windows.Forms.TextBox();
            this.grpCustomDate = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblDateFormatterDemo = new System.Windows.Forms.Label();
            this.grpTitleFormatter = new System.Windows.Forms.GroupBox();
            this.lblTitleModifierFormatterDemo = new System.Windows.Forms.Label();
            this.lblTitleFormatterDemo = new System.Windows.Forms.Label();
            this.txtTitleFormatter = new System.Windows.Forms.TextBox();
            this.rtfTitleFormatterGuide = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtfAlbumFormatterGuide = new System.Windows.Forms.RichTextBox();
            this.grpAlbumFormatter.SuspendLayout();
            this.grpCustomDate.SuspendLayout();
            this.grpTitleFormatter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(161, 464);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(246, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAlbumFormatter
            // 
            this.txtAlbumFormatter.Location = new System.Drawing.Point(8, 24);
            this.txtAlbumFormatter.Name = "txtAlbumFormatter";
            this.txtAlbumFormatter.Size = new System.Drawing.Size(296, 20);
            this.txtAlbumFormatter.TabIndex = 3;
            this.txtAlbumFormatter.TextChanged += new System.EventHandler(this.txtAlbumFormatter_TextChanged);
            // 
            // grpAlbumFormatter
            // 
            this.grpAlbumFormatter.Controls.Add(this.groupBox2);
            this.grpAlbumFormatter.Controls.Add(this.lblAlbumFormatterDemo);
            this.grpAlbumFormatter.Controls.Add(this.txtAlbumFormatter);
            this.grpAlbumFormatter.Location = new System.Drawing.Point(16, 112);
            this.grpAlbumFormatter.Name = "grpAlbumFormatter";
            this.grpAlbumFormatter.Size = new System.Drawing.Size(312, 152);
            this.grpAlbumFormatter.TabIndex = 4;
            this.grpAlbumFormatter.TabStop = false;
            this.grpAlbumFormatter.Text = "Album Formatter";
            // 
            // lblAlbumFormatterDemo
            // 
            this.lblAlbumFormatterDemo.AutoSize = true;
            this.lblAlbumFormatterDemo.Location = new System.Drawing.Point(8, 48);
            this.lblAlbumFormatterDemo.Name = "lblAlbumFormatterDemo";
            this.lblAlbumFormatterDemo.Size = new System.Drawing.Size(35, 13);
            this.lblAlbumFormatterDemo.TabIndex = 6;
            this.lblAlbumFormatterDemo.Text = "label1";
            // 
            // txtCustomDateFormatter
            // 
            this.txtCustomDateFormatter.Location = new System.Drawing.Point(8, 24);
            this.txtCustomDateFormatter.Name = "txtCustomDateFormatter";
            this.txtCustomDateFormatter.Size = new System.Drawing.Size(296, 20);
            this.txtCustomDateFormatter.TabIndex = 5;
            this.txtCustomDateFormatter.TextChanged += new System.EventHandler(this.txtCustomDateFormatter_TextChanged);
            // 
            // grpCustomDate
            // 
            this.grpCustomDate.Controls.Add(this.linkLabel1);
            this.grpCustomDate.Controls.Add(this.lblDateFormatterDemo);
            this.grpCustomDate.Controls.Add(this.txtCustomDateFormatter);
            this.grpCustomDate.Location = new System.Drawing.Point(16, 8);
            this.grpCustomDate.Name = "grpCustomDate";
            this.grpCustomDate.Size = new System.Drawing.Size(312, 100);
            this.grpCustomDate.TabIndex = 6;
            this.grpCustomDate.TabStop = false;
            this.grpCustomDate.Text = "Custom Date Format";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(20, 61);
            this.linkLabel1.Location = new System.Drawing.Point(8, 72);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(268, 17);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Formatted using the C# date and time format strings.";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblDateFormatterDemo
            // 
            this.lblDateFormatterDemo.AutoSize = true;
            this.lblDateFormatterDemo.Location = new System.Drawing.Point(8, 48);
            this.lblDateFormatterDemo.Name = "lblDateFormatterDemo";
            this.lblDateFormatterDemo.Size = new System.Drawing.Size(35, 13);
            this.lblDateFormatterDemo.TabIndex = 7;
            this.lblDateFormatterDemo.Text = "label1";
            // 
            // grpTitleFormatter
            // 
            this.grpTitleFormatter.Controls.Add(this.groupBox1);
            this.grpTitleFormatter.Controls.Add(this.lblTitleModifierFormatterDemo);
            this.grpTitleFormatter.Controls.Add(this.lblTitleFormatterDemo);
            this.grpTitleFormatter.Controls.Add(this.txtTitleFormatter);
            this.grpTitleFormatter.Location = new System.Drawing.Point(16, 272);
            this.grpTitleFormatter.Name = "grpTitleFormatter";
            this.grpTitleFormatter.Size = new System.Drawing.Size(312, 160);
            this.grpTitleFormatter.TabIndex = 7;
            this.grpTitleFormatter.TabStop = false;
            this.grpTitleFormatter.Text = "Title Formatter";
            // 
            // lblTitleModifierFormatterDemo
            // 
            this.lblTitleModifierFormatterDemo.AutoSize = true;
            this.lblTitleModifierFormatterDemo.Location = new System.Drawing.Point(8, 64);
            this.lblTitleModifierFormatterDemo.Name = "lblTitleModifierFormatterDemo";
            this.lblTitleModifierFormatterDemo.Size = new System.Drawing.Size(35, 13);
            this.lblTitleModifierFormatterDemo.TabIndex = 7;
            this.lblTitleModifierFormatterDemo.Text = "label1";
            // 
            // lblTitleFormatterDemo
            // 
            this.lblTitleFormatterDemo.AutoSize = true;
            this.lblTitleFormatterDemo.Location = new System.Drawing.Point(8, 48);
            this.lblTitleFormatterDemo.Name = "lblTitleFormatterDemo";
            this.lblTitleFormatterDemo.Size = new System.Drawing.Size(35, 13);
            this.lblTitleFormatterDemo.TabIndex = 6;
            this.lblTitleFormatterDemo.Text = "label1";
            // 
            // txtTitleFormatter
            // 
            this.txtTitleFormatter.Location = new System.Drawing.Point(8, 24);
            this.txtTitleFormatter.Name = "txtTitleFormatter";
            this.txtTitleFormatter.Size = new System.Drawing.Size(296, 20);
            this.txtTitleFormatter.TabIndex = 3;
            this.txtTitleFormatter.TextChanged += new System.EventHandler(this.txtTitleFormatter_TextChanged);
            // 
            // rtfTitleFormatterGuide
            // 
            this.rtfTitleFormatterGuide.BackColor = System.Drawing.SystemColors.Control;
            this.rtfTitleFormatterGuide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfTitleFormatterGuide.Location = new System.Drawing.Point(8, 16);
            this.rtfTitleFormatterGuide.Name = "rtfTitleFormatterGuide";
            this.rtfTitleFormatterGuide.ReadOnly = true;
            this.rtfTitleFormatterGuide.Size = new System.Drawing.Size(272, 48);
            this.rtfTitleFormatterGuide.TabIndex = 8;
            this.rtfTitleFormatterGuide.Text = "%t - Title\n%r - Title with article at the end\n%m - Modifier";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtfTitleFormatterGuide);
            this.groupBox1.Location = new System.Drawing.Point(8, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Template Vars";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtfAlbumFormatterGuide);
            this.groupBox2.Location = new System.Drawing.Point(8, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 80);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Template Vars";
            // 
            // rtfAlbumFormatterGuide
            // 
            this.rtfAlbumFormatterGuide.BackColor = System.Drawing.SystemColors.Control;
            this.rtfAlbumFormatterGuide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfAlbumFormatterGuide.Location = new System.Drawing.Point(8, 16);
            this.rtfAlbumFormatterGuide.Name = "rtfAlbumFormatterGuide";
            this.rtfAlbumFormatterGuide.ReadOnly = true;
            this.rtfAlbumFormatterGuide.Size = new System.Drawing.Size(272, 56);
            this.rtfAlbumFormatterGuide.TabIndex = 8;
            this.rtfAlbumFormatterGuide.Text = "%d - Format date in custom date format\n%v - Venue\n%c - City\n%s - State";
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 502);
            this.Controls.Add(this.grpTitleFormatter);
            this.Controls.Add(this.grpCustomDate);
            this.Controls.Add(this.grpAlbumFormatter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreferences";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.frmPreferences_Load);
            this.grpAlbumFormatter.ResumeLayout(false);
            this.grpAlbumFormatter.PerformLayout();
            this.grpCustomDate.ResumeLayout(false);
            this.grpCustomDate.PerformLayout();
            this.grpTitleFormatter.ResumeLayout(false);
            this.grpTitleFormatter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAlbumFormatter;
        private System.Windows.Forms.GroupBox grpAlbumFormatter;
        private System.Windows.Forms.Label lblAlbumFormatterDemo;
        private System.Windows.Forms.TextBox txtCustomDateFormatter;
        private System.Windows.Forms.GroupBox grpCustomDate;
        private System.Windows.Forms.Label lblDateFormatterDemo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox grpTitleFormatter;
        private System.Windows.Forms.Label lblTitleFormatterDemo;
        private System.Windows.Forms.TextBox txtTitleFormatter;
        private System.Windows.Forms.Label lblTitleModifierFormatterDemo;
        private System.Windows.Forms.RichTextBox rtfTitleFormatterGuide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtfAlbumFormatterGuide;
    }
}