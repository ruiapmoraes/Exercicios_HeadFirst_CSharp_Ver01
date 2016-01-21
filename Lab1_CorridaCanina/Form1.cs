using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_CorridaCanina
{
    public partial class Form1 : Form
    {
        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void rbJoe_CheckedChanged(object sender, EventArgs e)
        {
            lblBettor.Text = rbJoe.Text;
        }

        private void rbBob_CheckedChanged(object sender, EventArgs e)
        {
            lblBettor.Text = rbBob.Text;

        }

        private void rbAl_CheckedChanged(object sender, EventArgs e)
        {
            lblBettor.Text = rbAl.Text;

        }
    }
}
