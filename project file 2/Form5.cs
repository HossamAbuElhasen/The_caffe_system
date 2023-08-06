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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string line = listBox1.SelectedItem.ToString();

            string[] data = line.Split('_');

            txtID.Text = data[0];
            txtName.Text = data[1];
            txtSalry.Text = data[2];
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
            this.Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string salary = txtSalry.Text;

            string emp = "\n" + id + "_" + name + "_" + salary;



            File.AppendAllText("FI2.txt", emp);
            MessageBox.Show("Employee Added");
        }

        private void update_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("FI2.txt");
            string id = txtID.Text;
            string name = txtName.Text;
            string salary = txtSalry.Text;
            string emp = id + "_" + name + "_" + salary +"\n";
           

            lines[listBox1.SelectedIndex] = emp;
            File.WriteAllLines("FI2.txt", lines);
            MessageBox.Show("employee update");
            listBox1.Items.Clear();
            string[] content = File.ReadAllLines("FI2.txt");
            listBox1.Items.AddRange(content);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("FI2.txt");
            string[] Newlines = new string[lines.Length - 1];
            int x = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                if (i == listBox1.SelectedIndex)
                {
                    continue;
                }
                Newlines[x] = lines[i];
                x++;
            }
            File.WriteAllLines("FI2.txt", Newlines);
            MessageBox.Show("Emoloyee Deleted");


            listBox1.Items.Clear();
            string[] content = File.ReadAllLines("FI2.txt");
            listBox1.Items.AddRange(content);
        }

        private void sarech_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("FI2.txt");
           
            
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                 if(line.Contains(searchID.Text))  
                 
                 {

                     txtshow.Text += line + "\n"; 
                  
                 }

            }
            if (txtshow.Text == "")
            {
                txtshow.Text = "not found";
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(File.ReadAllLines("FI2.txt"));

        }

        private void clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtID.Text="";
            txtName.Text = "";
            txtSalry.Text = "";
            searchID.Text = "";
            txtshow.Text = "";

        }
    }
}
