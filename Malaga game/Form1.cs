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
    public partial class Form1 : Form
    {
        //SoundPlayer playerOfM = new SoundPlayer(@"D:\Desktop\pic Malaga game\Stardew-Valley-game-mix.wav.wav");


        public Form1()
        {
            InitializeComponent();
           // playerOfM.Play();
            //playerOfM.Load();
            
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
