﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_Planner
{
   
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            //Calls DinnerParty Constructor
            dinnerParty = new DinnerParty((int) numericUpDown1.Value,healthyBox.Checked,
                fancyBox.Checked);
            birthdayParty = new BirthdayParty((int)numberBirthday.Value,
                fancyBirthday.Checked, CAKEwRITING.Text);
            DisplayBirthdayPartyCost();
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            Console.WriteLine("I'm accesed");
            decimal Cost = dinnerParty.Cost;
            Console.WriteLine("Dinne party cost: " + Cost);
            costLabel.Text = Cost.ToString("c");
        }


        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void CAKEwRITING_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = CAKEwRITING.Text;
            DisplayBirthdayPartyCost();
        }
        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            birthdayCost.Text = cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyBox.Checked;
            DisplayDinnerPartyCost();
        }
    }
}