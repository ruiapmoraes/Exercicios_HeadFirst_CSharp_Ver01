﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag182_PinnerParty
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        private  int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecoration;

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecoration = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecoration = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecoration +
                    ((CostOfBeveragesPerPerson + CostOfFoodPerPerson)
                        * NumberOfPeople);
            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }

        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }
    }

    
}
