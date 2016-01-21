using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag159_JogosDeVerao
{
    class Triangle
    {
        double area;
        int height;
        int lenght;

        public static void Main(string[] args)
        {
            string result = "";
            int x = 0;
            Triangle[] ta = new Triangle[4];
            while (x < 4)
            {
                ta[x] = new Triangle();
                ta[x].height = (x + 1) * 2;
                ta[x].lenght = x + 4;
                ta[x].SetArea();
                result += "triangle " + x + ", area";
                result += " = " + ta[x].area + "\n";
                x = x + 1;
            }
            int y = x;
            x = 27;
            Triangle t5 = ta[2];
            ta[2].area = 343;
            result += "y = " + y;
            MessageBox.Show(result +
                           ", t5 area = " + t5.area);
        }

        void SetArea()
        {
            area = (height * lenght) / 2;
        }
    }
}
