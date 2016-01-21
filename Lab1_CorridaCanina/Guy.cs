using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_CorridaCanina
{
    class Guy
    {
        public string Name; // o nome do cara
        public Bet MyBet; // Uma instçancia do Bet() que tem a sua aposta
        public int Cash; // QUanto dinheiro ele tem

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLables()
        {
            // Defina minha etiqueta para a descrição da minha aposta e a etiqueta em meu
            // botão de rádio para mostrar meu dinheiro ("João tem 43 reais")
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + (Cash - MyBet.Amount) + " pounds.";

        }

        public void ClearBet()
        {
            // Redefina minha aposta para que seja zero
            MyBet = new Bet() { Amount = 0, Bettor = this };

        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            // Faça uma nova aposta e armazene-a no meu campo de aposta
            // Retorne true se o cara teve dinheiro suficiente para apostar
            if (Cash - BetAmount>=0)
            {
                MyBet = new Bet() { Amount = BetAmount, Bettor = this, Dog = DogToWin };
                return true;
            }
            else
            {
                MessageBox.Show(Form.ActiveForm, "You haven't got enough funds.", "Go Home");
                return false;
            }
        }

        public void Collect (int Winner)
        {
            // Cobre minha aposta se eu ganhei
        }
    }
}
