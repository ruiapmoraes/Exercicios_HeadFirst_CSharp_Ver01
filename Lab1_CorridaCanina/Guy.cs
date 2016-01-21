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
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLables()
        {
            // Defina minha etiqueta para a descrição da minha aposta e a etiqueta em meu
            // botão de rádio para mostrar meu dinheiro ("João tem 43 reais")

        }

        public void ClearBet()
        {
            // Redefina minha aposta para que seja zero
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            // Faça uma nova aposta e armazene-a no meu campo de aposta
            // Retorne true se o cara teve dinheiro suficiente para apostar
            return false;
        }

        public void Collect (int Winner)
        {
            // Cobre minha aposta se eu ganhei
        }
    }
}
