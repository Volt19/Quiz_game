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
using System.Media; 


namespace Malaga_game
{
    public partial class Form3 : Form
    {
        public string correctAnswer = null;
        private System.Diagnostics.Stopwatch Watch = new System.Diagnostics.Stopwatch();
        public int answeredQuestions = 0;
        Quiz quiz = new Quiz();
        public bool answerBool = true;
        public List<string> questions = new List<string>();
        public List<string> answers = new List<string>();
        Random randomQuestion = new Random();
        Random randomPsitionOfAnswers = new Random();
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public static int corectAnsweredQuestions = 0;
        public List<int> index = new List<int>();
        //SoundPlayer playerOfError = new SoundPlayer(@"D:\Desktop\pic Malaga game\mixkit-click-error-1110.wav");
        ////SoundPlayer playerOfClick = new SoundPlayer(@"D:\Desktop\pic Malaga game\mixkit-interface-click-1126.wav");
        //SoundPlayer playerOfcorect = new SoundPlayer(@"D:\Desktop\pic Malaga game\mixkit-melodic-bonus-collect-1938.wav");
        //SoundPlayer playerOffinish = new SoundPlayer(@"D:\Desktop\pic Malaga game\mixkit-game-level-completed-2059.wav");
        //SoundPlayer playerOfM = new SoundPlayer(@"D:\Desktop\pic Malaga game\Stardew-Valley-game-mix.wav.wav");


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label2.Text = string.Format("{0:00}:{1:00}:{2:00}", Watch.Elapsed.Hours,
                Watch.Elapsed.Minutes, Watch.Elapsed.Seconds);
            openFormX();

        }

        public void openForm4()
        {
            Application.Run(new Form4());
        }

        public void openFormX()
        {
            if (answeredQuestions == 15 && !Watch.IsRunning)
            {
                this.Close();
                Thread thread = new Thread(openForm4);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                //playerOffinish.Play();
               
            }
        }

        public void QuestionList()
        {
            for (int i = 0; i < quiz.NumberOfQuestions; i++)
            {
                questions.Add(quiz.questions[i]);
                index.Add(i);
            }
            Quizgame();
            corectAnsweredQuestions = 0;
        }

        public void Quizgame()
        {
            custom_button_11.Enabled = true;
            custom_button_12.Enabled = true;
            custom_button_13.Enabled = true;
            custom_button_14.Enabled = true;
            int numberOfquestion;            
            if (questions.Count > 1) 
            {
                 numberOfquestion = randomQuestion.Next(0, index.Count - 1);
            }
            else
            {
                numberOfquestion = randomQuestion.Next(0, index.Count);
            }
            for (int i = 0; i < 4; i++)
            {
                answers.Add(quiz.answers[index[numberOfquestion], i]);
                
            }
            label1.Text = questions[numberOfquestion];
            correctAnswer = answers[3];
            int random = randomPsitionOfAnswers.Next(0, answers.Count());
            custom_button_11.Text = answers[random]; answers.Remove(answers[random]);
            random = randomPsitionOfAnswers.Next(0, answers.Count());
            custom_button_12.Text = answers[random]; answers.Remove(answers[random]);
            random = randomPsitionOfAnswers.Next(0, answers.Count());
            custom_button_13.Text = answers[random]; answers.Remove(answers[random]);
            random = randomPsitionOfAnswers.Next(0, answers.Count());
            custom_button_14.Text = answers[random]; answers.Clear();
            questions.Remove(questions[numberOfquestion]);
            index.Remove(index[numberOfquestion]);
            label3.Text = $"{answeredQuestions}/15";

            
        }

        public Form3()
        {
            InitializeComponent();
            QuestionList();
            Watch.Start();
            myTimer.Tick += new EventHandler(TimerEventProcessor);


        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            if (questions.Count >= 1)
            {
                Quizgame();
            }                                    
            myTimer.Stop();                        
            if (answeredQuestions == 15)
            {
                Watch.Stop(); Quiz.timeL = label2.Text; Quiz.points = corectAnsweredQuestions.ToString();
            }
            //if (answeredQuestions == quiz.NumberOfQuestions && !Watch.IsRunning)
            //{
            //    this.Close();
            //    Thread thread = new Thread(openForm4);
            //    thread.SetApartmentState(ApartmentState.STA);
            //    thread.Start();
            //}

        }

        private void custom_buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            answerBool = false;
            custom_button_11.Enabled = false;
            custom_button_12.Enabled = false;
            custom_button_13.Enabled = false;
            custom_button_14.Enabled = false;
            if (button.Text == correctAnswer)
            {


                //playerOfcorect.Play();
                button.BackColor = Color.LightGreen;
                
                myTimer.Interval = 1000;
                myTimer.Start();
                corectAnsweredQuestions++;
                answeredQuestions++;
                
            }
            else
            {
                //playerOfError.Play();
                button.BackColor = Color.OrangeRed;                             
                if (custom_button_11.Text == correctAnswer)
                {
                    custom_button_11.BackColor = Color.LightGreen;
                }
                else if (custom_button_12.Text == correctAnswer)
                {
                    custom_button_12.BackColor = Color.LightGreen;
                }
                else if (custom_button_13.Text == correctAnswer)
                {
                    custom_button_13.BackColor = Color.LightGreen;
                }
                else if (custom_button_14.Text == correctAnswer)
                {
                    custom_button_14.BackColor = Color.LightGreen;
                }
                                
                myTimer.Interval = 1000;
                myTimer.Start();
                answeredQuestions++;                
            }
            label3.Text = $"{answeredQuestions}/15";
            


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            custom_button_11.BackColor = Color.DarkTurquoise;
            custom_button_12.BackColor = Color.DarkTurquoise;
            custom_button_13.BackColor = Color.DarkTurquoise;
            custom_button_14.BackColor = Color.DarkTurquoise;
            //playerOfM.Play();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Leave(object sender, EventArgs e)
        {
            corectAnsweredQuestions = 0;
        }
    }
}
