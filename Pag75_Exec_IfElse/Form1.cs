using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pag75_Exec_IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.BackColor = Color.Blue;
                MessageBox.Show("O checkbox está checado!");
            }
            else
            {
                label1.BackColor = Color.Red;
                MessageBox.Show("O checkbox não está checado!");
            }
        }
    }
}
