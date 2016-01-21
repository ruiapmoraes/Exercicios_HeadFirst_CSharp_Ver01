using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pag142_Elefantes
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;
        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        private void btnLucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void btnLloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            Elephant xTroca;// = new Elephant();
            xTroca = lucinda;
            lucinda = lloyd;
            lloyd = xTroca;
            //lloyd.WhoAmI();
            //lucinda.WhoAmI();
            MessageBox.Show("Objetos trocados");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.TellMe("Hi", lucinda);
            lloyd.SpeakTo(lucinda, "Hello");
            lucinda.EarSize = 4321;
            lloyd.WhoAmI();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            Elephant[] elephants = new Elephant[7];

            elephants[0] = new Elephant { Name = "Lloyd", EarSize = 40 };
            elephants[1] = new Elephant { Name = "Lucinda", EarSize = 33 };
            elephants[2] = new Elephant { Name = "Larry", EarSize = 42 };
            elephants[3] = new Elephant { Name = "Lucile", EarSize = 32 };
            elephants[4] = new Elephant { Name = "Lars", EarSize = 44 };
            elephants[5] = new Elephant { Name = "Linda", EarSize = 37 };
            elephants[6] = new Elephant { Name = "Humprey", EarSize = 45 };

            Elephant biggestEars = elephants[0];

            for (int i = 1; i < elephants.Length; i++)
            {
                if (elephants[i].EarSize > biggestEars.EarSize)
                {
                    biggestEars = elephants[i];
                }
                MessageBox.Show(biggestEars.EarSize.ToString());
            }            
        }
    }
}
