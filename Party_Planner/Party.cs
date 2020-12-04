﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public virtual decimal Cost { 
            get 
            {
                decimal baseCost = CalculateCostOfDecorations();
                baseCost += (NumberOfPeople * CostOfFoodPerPerson);
                if (NumberOfPeople > 12)
                {
                    baseCost += 100M;
                }
                return baseCost;
            } 
            
        }

        public decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50m;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            return costOfDecorations;
        }
    }
}
