using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting_Parlor
{
   public class Bet
    {
        public int Amount;// The amount of cash that was bet
        public int Dog;// The number of the dog the bet is on
        public Guy Bettor;//The guy who placed the bet
        public String GetDescription()
        {
          if (Amount == 0)
            {
                return (Bettor.Name + " hasn't placed a bet");
            }
            else
            {
                return (Bettor.Name + " bets" + Amount + " dog #" + Dog);
            }
        }
        public int Payout(int Winner)
        {
            if (Winner == Dog)
            {
                return (Amount);
            }
            else
            {
                return (-Amount);
            }
        }
    }
}
