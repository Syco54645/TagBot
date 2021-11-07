using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagBot.App.usercontrols
{
    public partial class ucTextFiles : UserControl
    {
        public frmMain frmMain;
        
        public ucTextFiles()
        {
            InitializeComponent();
        }

        public void clearListView()
        {
            lvTextFiles.Items.Clear();
        }

        public void addItem(ListViewItem item)
        {
            lvTextFiles.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            lvTextFiles.Columns[0].Width = lvTextFiles.Width - 4 - SystemInformation.VerticalScrollBarWidth;
            lvTextFiles.Items.Add(item);
        }

        private void lvTextFiles_DoubleClick(object sender, MouseEventArgs e)
        {
            var selectedFiles = lvTextFiles.SelectedItems;
            string fileName = selectedFiles[0].Text;
            frmText frmText = new frmText(frmMain.currentPath + "\\" + fileName);
            frmText.Show();
        }
    }
}
