using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();
        public Form1()
        {            
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Adicione uma tecla aleatória a Listbox
            listBox1.Items.Add((Keys)random.Next(60, 90));
            if (listBox1 .Items .Count >7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                timer1.Stop();
            }
        }
    }
}
