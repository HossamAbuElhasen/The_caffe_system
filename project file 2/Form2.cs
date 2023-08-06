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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
            this.Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string id = txtNum.Text;
            string name = txtDrink.Text;
            string cost = txtCost.Text;

            string Detals = "\n" + id + "_" + name + "_" + cost;



            File.AppendAllText("FI1.txt", Detals);
            MessageBox.Show("drink Added");
        }

        private void update_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("FI1.txt");
            string id = txtNum.Text;
            string name = txtDrink.Text;
            string cost = txtCost.Text;

            string Detals = id + "_" + name + "_" + cost ;
         

            lines[listBox1.SelectedIndex] = Detals;
            File.WriteAllLines("FI1.txt", lines);
            MessageBox.Show("drink update");
            listBox1.Items.Clear();
            string[] content = File.ReadAllLines("FI1.txt");
            listBox1.Items.AddRange(content);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string line = listBox1.SelectedItem.ToString();
            string[] data = line.Split('_');

            txtNum.Text = data[0];
           txtDrink.Text = data[1];
            txtCost.Text = data[2];
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("FI1.txt");
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
            File.WriteAllLines("FI1.txt", Newlines);
            MessageBox.Show("drink Deleted");

           
            listBox1.Items.Clear();
            string[] content = File.ReadAllLines("FI1.txt");
            listBox1.Items.AddRange(content);
        }

        private void show_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox1.Items.AddRange(File.ReadAllLines("FI1.txt"));
        }

        private void clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtNum.Text = "";
            txtDrink.Text = "";
            txtCost.Text = "";
        }
    }
}
