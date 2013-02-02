using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dogtrack
{
    public partial class Form1 : Form
    {

        Guy[] guy = new Guy[3];
        public Random Randomizer;
        Greyhound[] Dogs = new Greyhound [4];
       
        public Form1()
        {


            InitializeComponent();

            int StartPosition = pictureBox1.Location.X;
            int distance = pictureBox1.Width;

           // for (int i = 0; i < 4; i++)
           // {
           Dogs[0] = new Greyhound() { MyPictureBox = pictureBox5, RacetrackLength = distance, Location = pictureBox1.Location.X, Randomizer = Randomizer };
           Dogs[1] = new Greyhound() { MyPictureBox = pictureBox4, RacetrackLength = distance, Location = pictureBox1.Location.X, Randomizer = Randomizer };
           Dogs[2] = new Greyhound() { MyPictureBox = pictureBox2, RacetrackLength = distance, Location = pictureBox1.Location.X, Randomizer = Randomizer };    
           Dogs[3] = new Greyhound() { MyPictureBox = pictureBox3, RacetrackLength = distance, Location = pictureBox1.Location.X, Randomizer = Randomizer };    
                
                //Dogs[4] = new Greyhound();
                //Dogs[i].Randomizer = Randomizer;
                //Dogs[i].RacetrackLength = distance;
                //Dogs[i].Location = Dogs[i].StartingPosition = StartPosition;
            //}

            //Dogs[0].MyPictureBox = pictureBox5;
            //Dogs[1].MyPictureBox = pictureBox4;
            //Dogs[2].MyPictureBox = pictureBox2;
            //Dogs[3].MyPictureBox = pictureBox3;

            guy[0] = new Guy() { Cash = 50, Name = "Joe", MyRadioButton = radioButton1, MyLabel = label3, MyBet = null };
            guy[1] = new Guy() { Name = "Bob", Cash = 75, MyRadioButton = radioButton2, MyLabel = label4, MyBet = null };
            guy[2] = new Guy() { Name = "Al", Cash = 45, MyRadioButton = radioButton4, MyLabel = label5, MyBet = null };

            label1.Text = "Minimum: bet " + numericUpDown1.Minimum + " bucks";

            for (int i = 0; i < guy.Length; i++)
            {
                guy[i].UpdateLabels();
            }


            
        }




        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
            int winningDog;

            bool result = false;

            while (!result)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = Dogs[i].Run();
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                    if (result)
                    {
                        winningDog = i + 1;
                        MessageBox.Show("Dog #" + winningDog + " has won!");
                        guy[0].Collect(winningDog);
                        guy[1].Collect(winningDog);
                        guy[2].Collect(winningDog);
                        guy[0].ClearBet();
                        guy[1].ClearBet();
                        guy[2].ClearBet();
                        guy[0].UpdateLabels();
                        guy[1].UpdateLabels();
                        guy[2].UpdateLabels();
                        

                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                Dogs[i].TakeStartingPosition();
            }


        }
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                guy[0].PlaceBet((int)numericUpDown1.Value,
                (int)numericUpDown2.Value);
                guy[0].UpdateLabels();
            }

            else if (radioButton2.Checked)
            {
                guy[1].PlaceBet((int)numericUpDown1.Value,
                 (int)numericUpDown2.Value);
                guy[1].UpdateLabels();
            }

            else if (radioButton4.Checked)
            {

                guy[2].PlaceBet((int)numericUpDown1.Value,
                 (int)numericUpDown2.Value);
                guy[2].UpdateLabels();
            }



        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        
        


                
    }
}
    

     

        

        

