
namespace TagBot.App
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.okButton = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.wbDescription = new System.Windows.Forms.WebBrowser();
            this.rtbLegal = new System.Windows.Forms.RichTextBox();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(227, 361);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(9, 9);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(289, 343);
            this.tabMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(281, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TagBot";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.wbDescription, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblVersion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCopyright, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWebsite, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 311);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(269, 18);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "label5";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Location = new System.Drawing.Point(3, 18);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(269, 18);
            this.lblVersion.TabIndex = 30;
            this.lblVersion.Text = "label1";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Location = new System.Drawing.Point(3, 36);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(269, 19);
            this.lblCopyright.TabIndex = 31;
            this.lblCopyright.Text = "label2";
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWebsite.Location = new System.Drawing.Point(3, 55);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(269, 20);
            this.lblWebsite.TabIndex = 35;
            this.lblWebsite.TabStop = true;
            this.lblWebsite.Text = "linkLabel1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbLegal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(281, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Legal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // wbDescription
            // 
            this.wbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbDescription.Location = new System.Drawing.Point(3, 75);
            this.wbDescription.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.wbDescription.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDescription.Name = "wbDescription";
            this.wbDescription.Size = new System.Drawing.Size(269, 236);
            this.wbDescription.TabIndex = 25;
            this.wbDescription.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.wbDescription_Navigating);
            // 
            // rtbLegal
            // 
            this.rtbLegal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLegal.Location = new System.Drawing.Point(3, 3);
            this.rtbLegal.Name = "rtbLegal";
            this.rtbLegal.Size = new System.Drawing.Size(275, 311);
            this.rtbLegal.TabIndex = 0;
            this.rtbLegal.Text = "";
            // 
            // frmAbout
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 389);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About TagBot";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.LinkLabel lblWebsite;
        private System.Windows.Forms.WebBrowser wbDescription;
        private System.Windows.Forms.RichTextBox rtbLegal;
    }
}
