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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Action_Click(object sender, EventArgs e)
        {
            if (radioButton_Recent.Checked)
            {
                dataGridView_Recent.Visible = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton_Zip_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView_Recent.Visible == true)
            {
                dataGridView_Recent.Visible = false;
                groupBox_Zip.Visible = true;
                button_Action.Visible = false;
                button_Refresh_Grid.Visible = false;
                //button_Brow.Visible = true;
            }
            else
            {
                groupBox_Zip.Visible = true;
                //button_Brow.Visible = true;
            }
        }

       

        private void button_Browse_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            string fname = open.SafeFileName.ToString();
            textBox_Browse.Text = fname;
        }

        private void radioButton_Recent_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBox_Zip.Visible == true)
            {
                groupBox_Zip.Visible = false;
                dataGridView_Recent.Visible = true;
                button_Action.Visible = true;
            }
            
        }

        private void dataGridView_Recent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            textBox_Browse.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_Recent.da
        }

        
    }
}
