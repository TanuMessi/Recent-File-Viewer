using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecentFileViewer
{
    public partial class ZipHome : Form
    {
        public ZipHome()
        {
            InitializeComponent();
        }
        Boolean checkFile = false;
        string fileName;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                checkFile = true;
                fileName = openFile.SafeFileName.ToString();
                textBox1.Text = fileName;
                openFile.Dispose();
            }

        }
    }
}
