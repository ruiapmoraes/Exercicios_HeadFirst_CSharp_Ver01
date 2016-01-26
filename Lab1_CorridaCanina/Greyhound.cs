using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab1_CorridaCanina
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        //Adicionar posição
        private int AddLoc =0;

        public bool Run()
        {
            // Avance 1,2,3 ou 4 espaços aleatoriamente
            // Atualize a posição de pictureBox no formulário
            // Retorna true se eu ganhei a corrida
            Location = Randomizer.Next(1, 4);
            AddLoc += Location;
            MyPictureBox.Left = StartingPosition + AddLoc;
            if (MyPictureBox.Left >= RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            // Redefina minha posição para a linha de partida
            Location = 0;
            AddLoc = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
