using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pag204_Fazendeiro
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            //farmer = new Farmer() { NumberOfCows = 15, feedMultiplier = 30 };
            farmer = new Farmer(15, 30);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feed  for {1} cows",
                        farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            // farmer.BagsOfFeed = 5;
            //farmer.BagsOfFeed;
        }
    }
}
