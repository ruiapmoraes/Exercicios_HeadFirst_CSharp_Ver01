using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag216_PlanejadorDeFesta
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        //private  int NumberOfPeople;
        private int numberOfPeople;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        private bool fancyDecorations;


        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecoration;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

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
            //trecho antigo
            //decimal totalCost = CostOfDecoration +
            //        ((CostOfBeveragesPerPerson + CostOfFoodPerPerson)
            //            * NumberOfPeople);
            decimal totalCost = 0.0M;

            if (NumberOfPeople >= 12)

                totalCost = CostOfDecoration +
                        ((CostOfBeveragesPerPerson + CostOfFoodPerPerson)
                            * NumberOfPeople) + 100M;
            else
                totalCost = CostOfDecoration +
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
