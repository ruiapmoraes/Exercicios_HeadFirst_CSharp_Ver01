using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag142_Elefantes
{
    class Elephant
    {
        public string Name { get; set; }
        public int EarSize { get; set; }

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " inches tall.",
                        Name + " says...");
        }

        public void TellMe(string message , Elephant whoSadIt)
        {
            MessageBox.Show(whoSadIt.Name + " says: " + message);
        }

        public void SpeakTo(Elephant whoTalkTo,string message)
        {
            whoTalkTo.TellMe(message, this);
        }
    }
}
