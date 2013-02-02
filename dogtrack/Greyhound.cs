using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace dogtrack
{
    public class Greyhound
    {
               
        public int StartingPosition;  //where my picturebox starts
        public int RacetrackLength;  //How long the racetrack is 
        public PictureBox MyPictureBox = null;  //My Picturebox object
        public int Location = 0;   //My location on the racetrack
        public Random Randomizer;  //an instance of Random
        
        public void TakeStartingPosition() 
        {
            StartingPosition = 0; 
        }
        public bool Run()
        {
            Randomizer = new Random();
            int rand = Randomizer.Next(1,4);
            Point p = MyPictureBox.Location;
 
            if (p.X + rand >= RacetrackLength)
            {
                return true;
            }
            else
            {
                p.X += rand;
                MyPictureBox.Location = p;
                return false;
            }
 
        }
        
        
        
        
        
        //{

            // Move forward either 1, 2, 3, or 4 spaces at random
            // Update the position of my PictureBox on the form
            // Return true if I won the race

          //  Randomizer = new Random();
            
            //int distance = Randomizer.Next(1, 4);
            //Point p = MyPictureBox.Location;
            //p.X += distance;


            //if (p.X >= (RacetrackLength - this.MyPictureBox.Size.Width))
            //{
                //p.X = RacetrackLength - this.MyPictureBox.Size.Width;
                //MyPictureBox.Location = p;
                //return true;
            //}
            //else
            //{
                //MyPictureBox.Location = p;
                //return false;
            //}




            //Randomizer = new Random();
            //int r = Randomizer.Next(4);

            //Point p = MyPictureBox.Location;
            //p.X = p.X + r;
            //MyPictureBox.Location = p;

            //if (p.X >= RacetrackLength) 

            //return true;
            //else
            //return false;
        
            
            //move forward either 1,2,3,4 spaces at random
            //update the position of my PictureBox on the form
            //Return true if I won the race
        

        
    }

}
