using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpNombreMystere.Classes
{
    internal class Game
    {

        private int nbMystere;
        private int PickedNum;
        private int counter;
        private bool gameWin;

        public Game()
        {
            Start();
        }

        public int NbMystere { get => nbMystere; set => nbMystere = value; }
        public int PickedNum1 { get => PickedNum; set => PickedNum = value; }
        public int Counter { get => counter; set => counter = value; }
        public bool GameWin { get => gameWin; set => gameWin = value; }

        private int GenerateNumber()
        {
            Random random = new Random();
            return random.Next(1, 51);
        }

        private void Start()
        {
            GameWin = false;
            NbMystere = GenerateNumber();
            Counter = 0;
        }

        public string TestNum(int userNum)
        {
            if (userNum > 0)
            {                
                switch (userNum)
                {
                    case int tmpNum when tmpNum == NbMystere:
                        GameWin = true;
                        return Win();
                    case int tmpNum when tmpNum > NbMystere:
                        return "C'est moins...";
                    case int tmpNum when tmpNum < NbMystere:
                        return "C'est plus...";
                    default:
                        return "Erreur";
                }
            }
            else            
                return "Erreur";            
        }

        private string Win()
        {
            return $"Bravo, vous avez trouvé en {counter} coups!";
        }
    }
}
