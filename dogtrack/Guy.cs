using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dogtrack
{
    public class Guy 
    {
                            
        public string Name;  //guys name
        public Bet MyBet;  //an instance of bet used to wage bet
        public int Cash;  //How much cash he has
        public RadioButton MyRadioButton;  
        public Label MyLabel;

        public void UpdateLabels()
        {
            if (MyBet != null)
            {
                MyLabel.Text = MyBet.GetDescription();

                MyRadioButton.Text = Name + " has $" + this.Cash;
            }
            else
            {
                MyLabel.Text = Name + " hasn't placed a bet yet.";
                MyRadioButton.Text = Name + " has $" + this.Cash;
            }
        }
        public void ClearBet()
        {
            MyBet = null;
            
        }
        
        public bool PlaceBet(int Amount, int Dog)
        {
            if (this.Cash >= Amount && MyBet == null)
            {
                this.Cash -= Amount;
                MyBet = new Bet() { Amount = Amount, Dog = Dog, Bettor = this };
                UpdateLabels();
                return true;
            }
            else
            {
                MessageBox.Show(this.Name + " doesn't have enough cash to place this bet, or you already made your bet.");
                return false;
            }

        }     
            
            
          //  MyBet = new Bet();
            
           // {
             //   if (Cash >= Amount)
             //   {
              //      Cash = Cash - Amount;
                    
              //      MyBet.Amount = Amount;
              //      MyBet.Dog = Dog;
              //      UpdateLabels();
             //       return true;
             //   }
             //   else
             //   {
             //       return false;
            //    }


          //  }
       // }
        
                    


            //remember that bets are represented by instances of Bet.  
            //place a new bet and store it in my bet field
            //return true if the guy had enough money to bet
        

        public void Collect(int Winner) 
        {
        
        }
         
        


    }
}
