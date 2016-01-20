using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag113_JoeAndBob
{
    /// <summary>
    /// 
    /// </summary>
    class Guy
    {
        /// <summary>
        /// Campo somente de leitura name
        /// </summary>
        private readonly string name;
        /// <summary>
        /// O nome do cara
        /// </summary>
        public string  Name { get; set; }

        /// <summary>
        /// Campo somente leitura de age
        /// </summary>
        private readonly int age;
        /// <summary>
        /// A idade do cara
        /// </summary>
        public int Age { get; set; }


        /// <summary>
        /// O dinheiro do cara
        /// </summary>
        public int Cash { get; set; }

        /// <summary>
        /// O CONSTRUTOr define o nome, idade e dinheiro
        /// </summary>
        /// <param name="name">o nome do cara</param>
        /// <param name="age">a idade do cara</param>
        /// <param name="cash">o dinheiro do cara que começa</param>
        //public Guy(string name, int age, int cash)
        //{
        //    this.name = name;
        //    this.age = age;
        //    Cash = cash;
        //}

        public override string ToString()
        {
            return String.Format("{0} is {1} years old and has {2} bucks", Name, Age, Cash);
        }

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount >0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show(
                        "I don't have enough cash to give you " + amount,
                        Name + " says...");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " isn't an amount I'll take",
                        Name + " says...");
                return 0;
            }
        }
    }
}
