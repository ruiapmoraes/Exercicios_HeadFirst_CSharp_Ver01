using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pag135_ViagemReembolso
{
    public partial class Form1 : Form
    {
        int startingMileage = 0;
        int endingMileage = 0;
        double milesTraveled = 0.0;
        double reimburseRate = .39;
        double amountOwned = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            startingMileage =(int) numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;

            if ( startingMileage <= endingMileage )
            {
                //faça algo
                milesTraveled = endingMileage - startingMileage;
                amountOwned = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwned;
            }
            else
            {
                MessageBox.Show("A milhagem final é menor que a inicial.","Impossível Calcular");
            }
        }

        private void btnMiles_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }
    }
}
