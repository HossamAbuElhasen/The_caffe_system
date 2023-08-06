using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_file_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            f2.Show();
            this.Hide();
        }

        private void EMP_Click(object sender, EventArgs e)
        {
            Form5 f3 = new Form5();
            f3.Show();
            this.Hide();
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            Form6 f4 = new Form6();
            f4.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f5 = new Form1();
            f5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            Feedback.Visible = false;
            button3.Visible = false;



        }
    }
}
