using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagBot.Service.models;

namespace TagBot.App
{
    public partial class frmConfirmation : Form
    {
        public frmMain frmMain;
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            dgvChanges.Rows.Clear();
            dgvChanges.Font = new Font(this.Font.FontFamily.Name, 8);
            
            foreach (var item in frmMain.proposedMetadata)
            {
                string filename = item.Key;
                Metadata proposedMetadata = item.Value.Metadata;
                Metadata originalMetadata = frmMain.originalMetadata[filename].Metadata;
                bool addedFilename = false;
                List<string> metadataKeys = new List<string>
                {
                    "Title",
                    "Album",
                    "Artist",
                    "Date",
                    "Tracknumber",
                    //"Comment"
                };
                foreach (string mdk in metadataKeys)
                {
                    List<string> row = new List<string>();
                    string originalValue = "";
                    string proposedValue = "";
                    if (!string.IsNullOrEmpty((string)proposedMetadata[mdk]))
                    {
                        proposedValue = (string)proposedMetadata[mdk];
                    }
                    if (!string.IsNullOrEmpty((string)originalMetadata[mdk]))
                    {
                        originalValue = (string)originalMetadata[mdk];
                    }
                    if (false) { }
                    if (proposedValue.Trim() != originalValue.Trim())
                    {
                        if (!addedFilename)
                        {
                            row.Add(filename);
                            addedFilename = true;
                            dgvChanges.Rows.Add(row.ToArray());
                            row = new List<string>();
                        }
                        
                        row.Add(string.Empty);    
                        row.Add(mdk);
                        row.Add(originalValue);
                        row.Add(proposedValue);
                        if (row.Count > 0)
                        {
                            dgvChanges.Rows.Add(row.ToArray());
                        }
                        if (false) { }
                    }
                }
                if (false) { }
            }
            dgvChanges.AutoResizeColumns(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
