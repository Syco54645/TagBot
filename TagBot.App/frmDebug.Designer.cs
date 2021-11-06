
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
            this.rtfResult = new System.Windows.Forms.RichTextBox();
            this.rtfOriginal = new System.Windows.Forms.RichTextBox();
            this.rtfProposed = new System.Windows.Forms.RichTextBox();
            this.btnResetConfig = new System.Windows.Forms.Button();
            this.btnUpdateContention = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtfResult
            // 
            this.rtfResult.Location = new System.Drawing.Point(8, 8);
            this.rtfResult.Name = "rtfResult";
            this.rtfResult.Size = new System.Drawing.Size(320, 184);
            this.rtfResult.TabIndex = 3;
            this.rtfResult.Text = "";
            // 
            // rtfOriginal
            // 
            this.rtfOriginal.Location = new System.Drawing.Point(336, 8);
            this.rtfOriginal.Name = "rtfOriginal";
            this.rtfOriginal.Size = new System.Drawing.Size(320, 184);
            this.rtfOriginal.TabIndex = 4;
            this.rtfOriginal.Text = "";
            // 
            // rtfProposed
            // 
            this.rtfProposed.Location = new System.Drawing.Point(664, 8);
            this.rtfProposed.Name = "rtfProposed";
            this.rtfProposed.Size = new System.Drawing.Size(320, 184);
            this.rtfProposed.TabIndex = 5;
            this.rtfProposed.Text = "";
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.Location = new System.Drawing.Point(360, 296);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(75, 23);
            this.btnResetConfig.TabIndex = 6;
            this.btnResetConfig.Text = "Reset Config";
            this.btnResetConfig.UseVisualStyleBackColor = true;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // btnUpdateContention
            // 
            this.btnUpdateContention.Location = new System.Drawing.Point(568, 304);
            this.btnUpdateContention.Name = "btnUpdateContention";
            this.btnUpdateContention.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateContention.TabIndex = 7;
            this.btnUpdateContention.Text = "btnUpdateContention";
            this.btnUpdateContention.UseVisualStyleBackColor = true;
            this.btnUpdateContention.Click += new System.EventHandler(this.btnUpdateContention_Click);
            // 
            // frmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.btnUpdateContention);
            this.Controls.Add(this.btnResetConfig);
            this.Controls.Add(this.rtfProposed);
            this.Controls.Add(this.rtfOriginal);
            this.Controls.Add(this.rtfResult);
            this.Name = "frmDebug";
            this.Text = "frmDebug";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfResult;
        private System.Windows.Forms.RichTextBox rtfOriginal;
        private System.Windows.Forms.RichTextBox rtfProposed;
        private System.Windows.Forms.Button btnResetConfig;
        private System.Windows.Forms.Button btnUpdateContention;
    }
}