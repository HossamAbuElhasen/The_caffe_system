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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
            this.Hide();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string path = "feed.txt ";
            File.WriteAllText(path, txtpath.Text);
           
            if (File.Exists(path))
            {
                MessageBox.Show(" your complaints is send sucssful ");
            }
            else
            {
                File.Create(path);
                MessageBox.Show(" your complaints is send sucssful ");
            }
        }
        private void time_Click(object sender, EventArgs e)
        {
            string path = "feed.txt ";
            FileInfo obj = new FileInfo(path);
            txtsh.Text += obj.CreationTime.ToString("dd / MMMM / yyyy hh:mm : ss tt");
  
        }
    }
}
