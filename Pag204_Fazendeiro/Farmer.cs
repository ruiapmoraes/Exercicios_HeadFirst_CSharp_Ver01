using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag204_Fazendeiro
{
    class Farmer
    {
        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }

        public int  BagsOfFeed { get; private set; }
        //public const int FeedMultiplier = 30; remover esta lia do codigo pag. 206

        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }
        private int numberOfCows;

        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }

            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }
}
