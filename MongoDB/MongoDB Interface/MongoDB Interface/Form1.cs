using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDB_Interface
{
    public partial class LogIn : Form
    {

        int Attempt = 3;
        int TimeLeft;

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            TimeLeft = 20;
            TimeT.Text = "Time left, 20 seconds.";
            timer1.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Username.Text == "root")
            {
                if (Password.Text == "1234")
                {
                    this.Hide();
                    timer1.Stop();
                    System.Windows.Forms.MessageBox.Show("Welcome","Welcome");
                    Main frm2 = new Main();
                    frm2.ShowDialog();
                    
                }
                else
                {
                    Attempt = Attempt - 1;
                    System.Windows.Forms.MessageBox.Show("Incorrect Password "+Attempt+" attempts left");
                    if (Attempt == 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Too many failed attempts. Exiting");
                        System.Windows.Forms.Application.Exit();
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Incorrect Username");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(TimeLeft> 0)
            {
                TimeLeft =TimeLeft-1;
                TimeT.Text = "Time left, " +TimeLeft+" Seconds";
            }
            else
            {
                timer1.Stop();
                TimeT.Text = "Time´s up!";
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
