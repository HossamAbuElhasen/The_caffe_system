using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace project_file_2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void create_Click(object sender, EventArgs e)
        {
            if(! Directory.Exists(txt1.Text))
            {
                Directory.CreateDirectory(txt1.Text);
                MessageBox.Show("Floder  created ");

            }
            else
            {
                MessageBox.Show("the floder  existed");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txt1.Text))
            {
                Directory.Delete(txt1.Text);
                MessageBox.Show("Folder Deleted");
            }
            else
            {
                MessageBox.Show("Folder not existed");
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            string[] AllFile_patth = Directory.GetFiles(txt1.Text);
            txtshow.Lines = AllFile_patth; 
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtshow.Text="";
            txt1.Text = "E:\\cafe";
        }

        private void txtshow_TextChanged(object sender, EventArgs e)
        {

        }

        private void Floder_Click(object sender, EventArgs e)
        {
            string[] AllFolder_patth = Directory.GetDirectories(txt1.Text);
            txtshow.Lines = AllFolder_patth;
        }
    }
}
