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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
            this.Hide();
        }

        private void show_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(File.ReadAllLines("FI1.txt"));
        }

        private void request_Click(object sender, EventArgs e)
        {


            
            int x = int.Parse(txt1.Text);
            int y = int.Parse(txt2.Text);

            int sum = x + y;
            txtshow.Text = sum.ToString();

            
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string line = listBox1.SelectedItem.ToString();
            string[] data = line.Split('_');
            if (txt2.Text == "")
            {
                txt1.Text = data[2];
                txt2.Text = "0";

            }
            else
            {

                txt2.Text = data[2];
            }
            
           
         
        }

        private void clear_Click(object sender, EventArgs e)
        {
            
            txtshow.Text = "";
            txt1.Text = "";
            txt2.Text = "";

        }
    }
}
