using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vs_Harjoitukset_1_2
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void TestB1_Click(object sender, EventArgs e)
        {
            int together = int.Parse(Test1.Text) + int.Parse(Test2.Text);
            Test3.Text = together.ToString();
            
        }

        private void Test3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Test2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {
            TestL1.Text = "+";
        }
    }
}
