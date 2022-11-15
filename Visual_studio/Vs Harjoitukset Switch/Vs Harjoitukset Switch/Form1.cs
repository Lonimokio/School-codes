using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vs_Harjoitukset_Switch
{
    public partial class Switch : Form
    {
        double Percentage;
        public Switch()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int choice = int.Parse(C1.Text);
            switch (choice)
            {
                case 1:
                    AB.Text = "Potato";
                    break;
                case 2:
                    AB.Text = "Nope";
                    break;
                case 3:
                    AB.Text = "Carrot";
                    break;
                case 4:
                    AB.Text = "Chicken";
                    break;
                case 5:
                    AB.Text = "Bunny";
                    break;
            }
        }

        private void Choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Title = "Choice";
            int choice = int.Parse(Choice.Text);
            switch (choice)
            {
                case 1:
                    MessageBox.Show("Doctor Who", Title);
                    break;
                case 2:
                    MessageBox.Show("Star Trek", Title);
                    break;
                case 3:
                    MessageBox.Show("Solar Opposites", Title);
                    break;
                case 4:
                    MessageBox.Show("Rick And Morty", Title);
                    break;
                case 5:
                    MessageBox.Show("Agents of shield", Title);
                    break;
            }
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            double Math = Percentage * double.Parse(NU.Text);
            TB.Text = Math.ToString();

        }
        private void CLB_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = CLB.SelectedIndex;
            int count = CLB.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    CLB.SetItemChecked(i, false);
                }
                int Choice = CLB.SelectedIndex + 1;
                switch (Choice)
                {
                    case 1:
                        Percentage = 0.2;
                        break;
                    case 2:
                        Percentage = 0.3;
                        break;
                    case 3:
                        Percentage = 1;
                        break;
                    case 4:
                        Percentage = 0.5;
                        break;
                    case 5:
                        Percentage = 0.05;
                        break;
                }
            }


        }
    }
}   
