using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betting_Parlor
{
    public partial class Form1 : Form
    {
        Guy[] Guys=new Guy[3];
        Greyhound[] Greyhounds=new Greyhound[4];
        Guy Al;
        Guy Bob;
        Guy Joe;
        Greyhound dog_1;
        Greyhound dog_2;
        Greyhound dog_3;
        Greyhound dog_4;
        int racetrackLength;
        int winner;
        bool isRun=false;
        public Form1()
        {
     
            InitializeComponent();
            Al = new Guy() { Name = "Al", Cash = 45, MyLabel = alBetLabel, MyRadioButton = alRadioButton };
            Bob = new Guy() { Name = "Bob", Cash = 75, MyLabel = bobBetLabel, MyRadioButton = bobRadioButton };
            Joe = new Guy() { Name = "Joe", Cash = 50, MyLabel = joeBetLabel, MyRadioButton = joeRadioButton };
            Guys[0] = Al;
            Guys[1] = Bob;
            Guys[2] = Joe;
            racetrackLength = raceTrack.Width;
            minimumBetLabel.Text = "Minimum Bet is $5";
            joeRadioButton.Text = "Joe has "+Joe.Cash+" bucks";
            bobRadioButton.Text = "Bob has "+Bob.Cash+" bucks";
            alRadioButton.Text = "Al has "+Al.Cash+" bucks";
            joeBetLabel.Text = Joe.Name + "hasn't placed a bet";
            bobBetLabel.Text = Bob.Name + "hasn't placed a bet";
            alBetLabel.Text = Al.Name + "hasn't placed a bet";
            UpdateCashLabels();
            
        }
        //Updates the selected guy from checked radio button
        public Guy SelectGuy()
        {
            RadioButton[] radioButtonList = new RadioButton[3] { alRadioButton, bobRadioButton, joeRadioButton };
            int selected_button = 0;
            Guy selected_guy = null;
            for (int i=1; i < radioButtonList.Length; i++)
            {
                if (radioButtonList[i].Checked == true)
                {
                    selected_button = i;
                }
       
            }
            selected_guy = Guys[selected_button];
            betterLabel.Text = selected_guy.Name;
            return selected_guy;
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            Guy better =SelectGuy();
            int bet_amount =(int) betCounter.Value;
            int selected_dog = (int)dogCounter.Value;
            if(bet_amount != 0 && selected_dog<=3)
            {
                if (bet_amount > 5)
                {
                    better.PlaceBet(bet_amount, selected_dog,better);
                    UpdateBetLabels(better);

                }
                else
                {
                    MessageBox.Show("Bet amount is less than the minimum");
                }

            }
            else
            {
                MessageBox.Show("Choose a bet amount and a dog to run");
            }

            
        }
        public void UpdateBetLabels(Guy guy)
        {
            guy.MyLabel.Text = guy.MyBet.GetDescription();

        }
        public void UpdateCashLabels()
        {
            
            
            joeRadioButton.Text = "Joe has " + Joe.Cash + " bucks";
            bobRadioButton.Text = "Bob has " + Bob.Cash + " bucks";
            alRadioButton.Text = "Al has " + Al.Cash + " bucks";
        }

        public void CalculatePayout(int winner)
        {
            for (int i=0; i < Guys.Length; i++)
            {
                Guys[i].Collect(winner);

            }
            
        }
        private void raceButton_Click(object sender, EventArgs e)
        {
            dog_1 = new Greyhound() { MyPictureBox = dog1PictureBox, racetrackLength = racetrackLength, startingPosition = dog1PictureBox.Location.X };
            dog_2 = new Greyhound() { MyPictureBox = dog2PictureBox, racetrackLength = racetrackLength, startingPosition = dog2PictureBox.Location.X };
            dog_3 = new Greyhound() { MyPictureBox = dog3PictureBox, racetrackLength = racetrackLength, startingPosition = dog3PictureBox.Location.X };
            dog_4 = new Greyhound() { MyPictureBox = dog4PictureBox, racetrackLength = racetrackLength, startingPosition = dog4PictureBox.Location.X };
            Greyhounds[0] = dog_1;
            Greyhounds[1] = dog_2;
            Greyhounds[2] = dog_3;
            Greyhounds[3] = dog_4;
            if (isRun)
            {
                timer1.Start();
                isRun = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            SelectGuy();
            Random randomnum = new Random();
            int advance_value;
            bool win;
            for (int i = 0; i < Greyhounds.Length; i++)
            {
                if (Greyhounds[i] != null)
                {
                    advance_value = randomnum.Next(5);
                    win=Greyhounds[i].Run(advance_value);
                    if (win)
                    {
                        winner = i;
                        isRun = true;
                        timer1.Stop();
                        MessageBox.Show("Dog # " + winner + " won the race!", "We have a Winner");
                        CalculatePayout(winner);
                        break;
                    }
                    
                }
                
            }

            
            
            
        }

        private void betAgainButton_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < Greyhounds.Length; i++)
            {
                Greyhounds[i].TakeStartingPosition();
            }
           

        }
    }
}
