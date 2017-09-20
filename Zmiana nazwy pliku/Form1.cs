using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zmiana_nazwy_pliku
{
    public partial class Form1 : Form
    {
        private string directoryChangeFile;
        private ZmianaNazwy zmianaNazwy;

        public Form1()
        {
            InitializeComponent();
            zmianaNazwy = new ZmianaNazwy(changeProgress);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            changeProgress.Value = 0;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                directoryChangeFile = folderBrowserDialog1.SelectedPath;                
            }
        }

        private void changFileButton_Click(object sender, EventArgs e)
        {
            zmianaNazwy.ChangeName(directoryChangeFile);
            
        }
    }
}
