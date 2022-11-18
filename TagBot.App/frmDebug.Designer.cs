
namespace TagBot.App
{
    partial class frmDebug
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
            this.rtfSearchResult = new System.Windows.Forms.RichTextBox();
            this.rtfOriginalMetadata = new System.Windows.Forms.RichTextBox();
            this.rtfProposedMetadata = new System.Windows.Forms.RichTextBox();
            this.btnResetConfig = new System.Windows.Forms.Button();
            this.btnUpdateContention = new System.Windows.Forms.Button();
            this.btnRefreshTextBoxes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRepairTrackNumbers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtfSearchResult
            // 
            this.rtfSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfSearchResult.Location = new System.Drawing.Point(3, 16);
            this.rtfSearchResult.Name = "rtfSearchResult";
            this.rtfSearchResult.Size = new System.Drawing.Size(322, 373);
            this.rtfSearchResult.TabIndex = 3;
            this.rtfSearchResult.Text = "";
            // 
            // rtfOriginalMetadata
            // 
            this.rtfOriginalMetadata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfOriginalMetadata.Location = new System.Drawing.Point(3, 16);
            this.rtfOriginalMetadata.Name = "rtfOriginalMetadata";
            this.rtfOriginalMetadata.Size = new System.Drawing.Size(322, 373);
            this.rtfOriginalMetadata.TabIndex = 4;
            this.rtfOriginalMetadata.Text = "";
            // 
            // rtfProposedMetadata
            // 
            this.rtfProposedMetadata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfProposedMetadata.Location = new System.Drawing.Point(3, 16);
            this.rtfProposedMetadata.Name = "rtfProposedMetadata";
            this.rtfProposedMetadata.Size = new System.Drawing.Size(322, 373);
            this.rtfProposedMetadata.TabIndex = 5;
            this.rtfProposedMetadata.Text = "";
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetConfig.Location = new System.Drawing.Point(304, 408);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(104, 23);
            this.btnResetConfig.TabIndex = 6;
            this.btnResetConfig.Text = "Reset Config";
            this.btnResetConfig.UseVisualStyleBackColor = true;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // btnUpdateContention
            // 
            this.btnUpdateContention.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateContention.Location = new System.Drawing.Point(416, 408);
            this.btnUpdateContention.Name = "btnUpdateContention";
            this.btnUpdateContention.Size = new System.Drawing.Size(120, 23);
            this.btnUpdateContention.TabIndex = 7;
            this.btnUpdateContention.Text = "Update Contention";
            this.btnUpdateContention.UseVisualStyleBackColor = true;
            this.btnUpdateContention.Click += new System.EventHandler(this.btnUpdateContention_Click);
            // 
            // btnRefreshTextBoxes
            // 
            this.btnRefreshTextBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshTextBoxes.Location = new System.Drawing.Point(544, 408);
            this.btnRefreshTextBoxes.Name = "btnRefreshTextBoxes";
            this.btnRefreshTextBoxes.Size = new System.Drawing.Size(120, 23);
            this.btnRefreshTextBoxes.TabIndex = 8;
            this.btnRefreshTextBoxes.Text = "Refresh Text Boxes";
            this.btnRefreshTextBoxes.UseVisualStyleBackColor = true;
            this.btnRefreshTextBoxes.Click += new System.EventHandler(this.btnRefreshTextBoxes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rtfSearchResult);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 392);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Result";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.rtfOriginalMetadata);
            this.groupBox2.Location = new System.Drawing.Point(336, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 392);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Original Metadata";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rtfProposedMetadata);
            this.groupBox3.Location = new System.Drawing.Point(672, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 392);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proposed Metadata";
            // 
            // btnRepairTrackNumbers
            // 
            this.btnRepairTrackNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepairTrackNumbers.Location = new System.Drawing.Point(844, 408);
            this.btnRepairTrackNumbers.Name = "btnRepairTrackNumbers";
            this.btnRepairTrackNumbers.Size = new System.Drawing.Size(145, 23);
            this.btnRepairTrackNumbers.TabIndex = 12;
            this.btnRepairTrackNumbers.Text = "Repair Track Numbers";
            this.btnRepairTrackNumbers.UseVisualStyleBackColor = true;
            this.btnRepairTrackNumbers.Click += new System.EventHandler(this.btnRepairTrackNumbers_Click);
            // 
            // frmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.btnRepairTrackNumbers);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefreshTextBoxes);
            this.Controls.Add(this.btnUpdateContention);
            this.Controls.Add(this.btnResetConfig);
            this.Name = "frmDebug";
            this.Text = "frmDebug";
            this.Load += new System.EventHandler(this.frmDebug_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfSearchResult;
        private System.Windows.Forms.RichTextBox rtfOriginalMetadata;
        private System.Windows.Forms.RichTextBox rtfProposedMetadata;
        private System.Windows.Forms.Button btnResetConfig;
        private System.Windows.Forms.Button btnUpdateContention;
        private System.Windows.Forms.Button btnRefreshTextBoxes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRepairTrackNumbers;
    }
}