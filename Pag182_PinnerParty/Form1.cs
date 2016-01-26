using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pag182_PinnerParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            //dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerParty = new DinnerParty((int)numericUpDown1.Value,
                                            healthyBox.Checked, fancyBox.Checked);
            dinnerParty.SetHealthyOption(fancyBox.Checked);
            dinnerParty.CalculateCostOfDecorations(healthyBox.Checked);

            DisplaDinnerPartyCost();
            
        }

        private void DisplaDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthyBox.Checked);
            labelCost.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplaDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplaDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyBox.Checked);
            DisplaDinnerPartyCost();
        }

    }
}
