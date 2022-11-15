using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vs_Harjoitukset_quiz
{
    public partial class Quiz : Form
    {
        int TimeLeft;
        int Points;
        int Question = 1;
        string Answer;
        public Quiz()
        {
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            TimeLeft = 15;
            Time.Text = "Time left 15 seconds";
            TM.Start();
        }

        private void QL_Click(object sender, EventArgs e)
        {

        }

        private void QB_Click(object sender, EventArgs e)
        {
            if (Question == 1)
            {
                Answer = QBox.Text;
                if (Answer == "16")
                {
                    Points++;
                    string message = "You got it rigth";
                    string title = "Correct";
                    MessageBox.Show(message, title);

                }
                else
                {
                    string message = "You got it wrong";
                    string title = "Wrong";
                    MessageBox.Show(message, title);
                }
                QL.Text = "Whats 9+12";
                QBox.Text = "";
                Question++;
                TimeLeft = 15;
            }

            else if (Question == 2)
                {
                    Answer = QBox.Text;
                    if (Answer == "21")
                    {
                        Points++;
                        string message = "You got it rigth";
                        string title = "Correct";
                        MessageBox.Show(message, title);
                    }
                    else
                    {
                        string message = "You got it wrong";
                        string title = "Wrong";
                        MessageBox.Show(message, title);
                    }
                    QL.Text = "What mob was creeper meant to be originally";
                    QBox.Text = "";
                    Question++;
                    TimeLeft = 15;
            }
            else if (Question == 3)
            {
                Answer = QBox.Text;
                if (Answer == "Pig")
                {
                    Points++;
                    string message = "You got it rigth";
                    string title = "Correct";
                    MessageBox.Show(message, title);

                }
                else
                {
                    string message = "You got it wrong";
                    string title = "Wrong";
                    MessageBox.Show(message, title);
                }
                QL.Text = "Thats all";
                QBox.Text = "you got " + Points + " Points";
                Question++;
                TM.Stop();
                Time.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeLeft > 0)
            {
                TimeLeft = TimeLeft-1;
                Time.Text = "Time left " + TimeLeft + " seconds";
            }
            else
            {
                Time.Text = "Time´s up";
                Question++;
                if (Question == 1)
                {
                    QL.Text = "Whats 9+12";
                    QBox.Text = "";
                    TimeLeft = 15;
                }
                else if (Question == 2)
                {
                    QL.Text = "What mob was creeper meant to be originally";
                    QBox.Text = "";
                    TimeLeft = 15;
                }
                else if (Question == 3)
                {
                    QL.Text = "Thats all";
                    QBox.Text = "you got " + Points + " Points";
                    TM.Stop();
                    Time.Text = "";
                }
            }
        }


    }
    }
