using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betting_Parlor
{
     public class Guy
    {
        public string Name;
        public Bet MyBet = new Bet() { Amount = 0 };
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
        
        public void UpdateLabels()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }
        public void ClearBet()
        {
            
            MyBet.Amount = 0;
             
        }
        public bool PlaceBet(int BetAmount, int DogToWin,Guy bettor)
        {
            if(Cash>5)
            {
                MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin,Bettor=this};
                return true;
            }
            else
            {
                MessageBox.Show(Name + " does not have enough money to bet!");
                return false;
            }
           
            
        }
        public void Collect(int winner)
        {
            Console.WriteLine("Guy"+ Name);
            Console.WriteLine("Dog"+ MyBet.Dog);
            Cash += MyBet.Payout(winner);
            ClearBet();
            UpdateLabels();

        }

    }
}
