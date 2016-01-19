using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag101_Palhacos
{
    class Clown
    {
        public string Name { get; set; }
        public int Height { get; set; }

        public void TalkAboutYourselft()
        {
            MessageBox.Show("My name is "
                    + Name + " and I'am "
                    + Height + " inches tall.");
        }
    }
}
