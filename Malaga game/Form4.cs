using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Malaga_game
{
    public partial class Form4 : Form
    {
        private System.Diagnostics.Stopwatch Watch = new System.Diagnostics.Stopwatch();
        Quiz quiz = new Quiz();
        public Form4()
        {
            InitializeComponent();
            label1.Text = "Time: "+Quiz.timeL;
            label2.Text = "Correct answers: " + Quiz.points;
        }

        private void Form4_Leave(object sender, EventArgs e)
        {
            Form3.corectAnsweredQuestions = 0;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            Random random = new Random();
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            int ran = random.Next(1, 3);
            if (Form3.corectAnsweredQuestions > quiz.NumberOfQuestions/2)
            {
                if (ran == 1)
                {
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox3.Visible = true;
                }
            }
            else
            {
                if (ran == 1)
                {
                    pictureBox2.Visible = true;
                }
                else
                {
                    pictureBox4.Visible = true;
                }
            }

        }

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        public void openForm()
        {
            Application.Run(new Form3());
        }

        private void custom_button_11_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Form4_Leave_1(object sender, EventArgs e)
        {

        }
    }
}
