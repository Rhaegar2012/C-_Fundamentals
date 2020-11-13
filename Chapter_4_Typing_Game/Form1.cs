using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4_Typing_Game
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();
        public Form1()
        {
            InitializeComponent();
  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Add a random key to the ListBox
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                timer1.Stop();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   //If the user pressed a key that's i the ListBox, remove it
            //and then make the game a little faster
            if(listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                //Increases the difficulty by accelating the game
                if (timer1.Interval > 400) timer1.Interval -= 10;
                if (timer1.Interval > 250) timer1.Interval -= 7;
                if (timer1.Interval > 100) timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;
                //The user pressed a correct key, so update the Stats object
                stats.Update(true);
            }
            else
            {
                //The user pressed an incorrect key so update the Stats object 
                stats.Update(false);
            }
            //Update form lavels with stats information 
            Update_Labels();
           
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            timer1.Start();
            stats.Correct = 0;
            stats.Missed = 0;
            stats.Accuracy = 0;
            stats.Total = 0;
            Update_Labels();

        }

        private void Update_Labels()
        {
            //Update form lavels with stats information 
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
        }
    }
}
