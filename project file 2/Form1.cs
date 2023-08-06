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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Next_Click(object sender, EventArgs e)
        {


             if (txtEm.Text=="admin" && TxtPass.Text=="1234") 
             {
                Form3 f2 = new Form3();
                f2.Show();
                this.Hide();
             }
            else
            {
                MessageBox.Show("The Email or password Not correct");
            }
            
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            TxtPass.MaxLength = 8;
            TxtPass.PasswordChar = '*';
            TxtPass.CharacterCasing = CharacterCasing.Lower;
            TxtPass.TextAlign = HorizontalAlignment.Center;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
