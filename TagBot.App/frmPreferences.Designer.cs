
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
            this.lvAlbumFormatters = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCustomDateFormatter = new System.Windows.Forms.TextBox();
            this.grpCustomDate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblDateFormatterDemo = new System.Windows.Forms.Label();
            this.grpAlbumFormatter.SuspendLayout();
            this.grpCustomDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(456, 368);
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
            this.btnCancel.Location = new System.Drawing.Point(552, 368);
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
            this.grpAlbumFormatter.Controls.Add(this.lblAlbumFormatterDemo);
            this.grpAlbumFormatter.Controls.Add(this.lvAlbumFormatters);
            this.grpAlbumFormatter.Controls.Add(this.txtAlbumFormatter);
            this.grpAlbumFormatter.Location = new System.Drawing.Point(16, 128);
            this.grpAlbumFormatter.Name = "grpAlbumFormatter";
            this.grpAlbumFormatter.Size = new System.Drawing.Size(312, 192);
            this.grpAlbumFormatter.TabIndex = 4;
            this.grpAlbumFormatter.TabStop = false;
            this.grpAlbumFormatter.Text = "Album Formatter";
            // 
            // lblAlbumFormatterDemo
            // 
            this.lblAlbumFormatterDemo.AutoSize = true;
            this.lblAlbumFormatterDemo.Location = new System.Drawing.Point(8, 56);
            this.lblAlbumFormatterDemo.Name = "lblAlbumFormatterDemo";
            this.lblAlbumFormatterDemo.Size = new System.Drawing.Size(35, 13);
            this.lblAlbumFormatterDemo.TabIndex = 6;
            this.lblAlbumFormatterDemo.Text = "label1";
            // 
            // lvAlbumFormatters
            // 
            this.lvAlbumFormatters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvAlbumFormatters.HideSelection = false;
            this.lvAlbumFormatters.Location = new System.Drawing.Point(8, 80);
            this.lvAlbumFormatters.Name = "lvAlbumFormatters";
            this.lvAlbumFormatters.Size = new System.Drawing.Size(296, 104);
            this.lvAlbumFormatters.TabIndex = 5;
            this.lvAlbumFormatters.UseCompatibleStateImageBehavior = false;
            this.lvAlbumFormatters.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Format";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
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
            this.grpCustomDate.Controls.Add(this.label1);
            this.grpCustomDate.Controls.Add(this.linkLabel1);
            this.grpCustomDate.Controls.Add(this.lblDateFormatterDemo);
            this.grpCustomDate.Controls.Add(this.txtCustomDateFormatter);
            this.grpCustomDate.Location = new System.Drawing.Point(16, 16);
            this.grpCustomDate.Name = "grpCustomDate";
            this.grpCustomDate.Size = new System.Drawing.Size(312, 100);
            this.grpCustomDate.TabIndex = 6;
            this.grpCustomDate.TabStop = false;
            this.grpCustomDate.Text = "Custom Date Format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Formatted using the standard ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(152, 72);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "C# date and time format strings.";
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
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 406);
            this.Controls.Add(this.grpCustomDate);
            this.Controls.Add(this.grpAlbumFormatter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Name = "frmPreferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.frmPreferences_Load);
            this.grpAlbumFormatter.ResumeLayout(false);
            this.grpAlbumFormatter.PerformLayout();
            this.grpCustomDate.ResumeLayout(false);
            this.grpCustomDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAlbumFormatter;
        private System.Windows.Forms.GroupBox grpAlbumFormatter;
        private System.Windows.Forms.ListView lvAlbumFormatters;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblAlbumFormatterDemo;
        private System.Windows.Forms.TextBox txtCustomDateFormatter;
        private System.Windows.Forms.GroupBox grpCustomDate;
        private System.Windows.Forms.Label lblDateFormatterDemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}