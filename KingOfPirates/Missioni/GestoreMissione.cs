using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni
{
    class GestoreMissione
    {
        private int punteggio,
            numeroTurni,
            rubiniRaccolti;
        private bool gameOver;

        public GestoreMissione()
        {
            this.punteggio = 0;
            this.numeroTurni = 0;
            this.rubiniRaccolti = 0;
            this.gameOver = false;
        }

        public void AumentaPunteggio(int guadagno)
        {
            //TODO
        }

        public void AbbassaPunteggio(int spesa)
        {
            //TODO
        }
        
        // getter/setter

        public int Punteggio { get => punteggio; set => punteggio = value; }
        public int NumeroTurni { get => numeroTurni; set => numeroTurni = value; }
        public int RubiniRaccolti { get => rubiniRaccolti; set => rubiniRaccolti = value; }
        public bool GameOver { get => gameOver; set => gameOver = value; }
    }
}
