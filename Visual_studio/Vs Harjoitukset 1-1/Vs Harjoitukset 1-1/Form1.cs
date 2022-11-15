using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vs_Harjoitukset_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TestBox.Text ="";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string message = TestBox.Text;
            string title = "This is a title";
            MessageBox.Show(message, title);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
