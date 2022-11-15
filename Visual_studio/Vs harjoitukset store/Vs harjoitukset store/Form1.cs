using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vs_harjoitukset_store
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void EL_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Choice = EL.SelectedIndex + 1;
            switch (Choice)
            {
                case 1:
                    ERB.Text = "Good all around keyboard";
                    EB.ImageLocation = "";
                    break;
                case 2:
                    ERB.Text = "Good all around Mouse";
                    EB.ImageLocation = "";
                    break;
                case 3:
                    ERB.Text = "Good all around Screen";
                    EB.ImageLocation = "";
                    break;
                case 4:
                    ERB.Text = "Good all around Mouse pad";
                    EB.ImageLocation = "";
                    break;
                case 5:
                    ERB.Text = "Good all around Headphones";
                    EB.ImageLocation = "";
                    break;
            }
        }

        private void PL_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Choice = PL.SelectedIndex + 1;
            switch (Choice)
            {
                case 1:
                    PRB.Text = "Good all around CPU";
                    PB.ImageLocation = "";
                    break;
                case 2:
                    PRB.Text = "Good all around Motherboard";
                    PB.ImageLocation = "";
                    break;
                case 3:
                    PRB.Text = "Good all around GPU";
                    PB.ImageLocation = "";
                    break;
                case 4:
                    PRB.Text = "Good all around RAM";
                    PB.ImageLocation = "";
                    break;
                case 5:
                    PRB.Text = "Good all around Fan";
                    PB.ImageLocation = "";
                    break;
            }
        }

        private void PreL_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Choice = PreL.SelectedIndex + 1;
            switch (Choice)
            {
                case 1:
                    PreRB.Text = "Its the not so migthy potato pc";
                    PB.ImageLocation = "";
                    break;
                case 2:
                    PreRB.Text = "Its the actually usable PC. Gaming anyone?";
                    PB.ImageLocation = "";
                    break;
                case 3:
                    PreRB.Text = "This Pc will easily be enough for most people";
                    PB.ImageLocation = "";
                    break;
            }
        }

        private void Ecart_Click(object sender, EventArgs e)
        {
            SC.Items.Add(EL.Text);
        }
    }
}
