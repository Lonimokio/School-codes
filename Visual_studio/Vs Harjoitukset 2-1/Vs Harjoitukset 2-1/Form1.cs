using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vs_Harjoitukset_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Hello there "+TestBox1.Text;
            string title = "";
            MessageBox.Show(message, title);
            int Numbers =  int.Parse() TestBox2.Text - 2022;
        }
         private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestB2_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to close the program?";
            string title = "Close program";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) {  this.Close();  
            } else {
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
