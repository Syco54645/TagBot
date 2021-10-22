using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tagbot.Service;

namespace TagBot.App1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            txtDate.Text = "2009-09-19";
            if (string.IsNullOrEmpty(txtDate.Text))
            {
                MessageBox.Show("Date is required");
                return;
            }
            Sqlite sqlite = new Sqlite();
            rtfResult.Document.Blocks.Clear();
            rtfResult.Document.Blocks.Add(new Paragraph(new Run(sqlite.getShow(txtDate.Text))));
        }
    }
}
