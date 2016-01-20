﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pag113_JoeAndBob
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {
            joeCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + "has $" + bob.Cash;
            banckCashLabel.Text = "The bank has $" + bank;
        }

        public Form1()
        {
            InitializeComponent();
            // inicialize joe e bob aqui!

            bob = new Guy { Name = "Bob", Cash = 100 };

            joe = new Guy { Cash = 50, Name = "Joe" };
           

            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >=10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash ( bob.GiveCash(5));
            UpdateForm();
        }
    }
}
