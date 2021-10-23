using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagBot.App
{
    public partial class frmText : Form
    {
        public frmText()
        {
            InitializeComponent();
        }

        public frmText(string path)
        {
            InitializeComponent();

            string textFile = File.ReadAllText(path);
            this.Text = path;
            rtfTextViewer.Text = textFile;
        }

    }
}
