using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class DinnerParty:Party
    {
      
        public bool HealthyOption { get; set; }
 
        public override decimal Cost
        {
            // The get will return the value, it can also be used as a method to assign
            //value without set , Use set when the variable needs to be accesed and modified  by someone else
            get
            {
                decimal totalCost = base.Cost;
                totalCost += (CalculateCostOfBeveragesPerPerson() * NumberOfPeople);
                if (HealthyOption)
                {
                    totalCost *= 0.95M;
                }
                Console.WriteLine("DINNER COST" + totalCost);
                return totalCost;
            }
     
        }
        // Class constructor , initializes NumberOfPeople, FancyDecorations  and HealthyOption
        public DinnerParty(int numberOfPeople,bool healthyOption,bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }
        
       

        public decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson= 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson= 20.00M;
            }
            return costOfBeveragesPerPerson;
        }

    }
}
