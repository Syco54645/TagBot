
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
            // frmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
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
    }
}