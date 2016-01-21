using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_CorridaCanina
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            // Retorne uma string que diga quem fez aposta, quanto
            // dinheiro foi apostado e em qual cão ("Jão apostou 8
            // no cao #4"). Se a quantidade for zero, a aposta não foi feita
            // ("João não apostou")
            return string.Empty;
        }

        public int PayOut(int Winner)
        {
            // O parâmetro é o vencedor da corrida. Se o cão venceu ,
            // retorne a quantia apostada. De outra forma, retorne um valor
            // negativo do valor apostado.
            return 0;
        }
    }
}
