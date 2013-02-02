using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogtrack
{
    public class Bet    ///Guy object will use this class to represent bets in the application.
    {
        public int Amount;  //The amount of cash that was bet
        public int Dog; //the number of the dog the bet was placed
        public Guy Bettor;  //guy who placed bet

        public string GetDescription()
        {
            return (Bettor.Name + " has placed " + Amount + " bucks on Dog " + Dog);

                 

        }
        
        public int Payout(int Winner)
        {
            if (Dog == Winner)
                return Amount;
            else
                return -Amount;
            //the parameter is the winner of the race.  If the dog won, return the amount betted.  Otherwise return negative amount of bet.
        }

    }
}
