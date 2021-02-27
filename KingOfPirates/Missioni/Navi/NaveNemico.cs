using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //Per le Bitmap
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;

namespace KingOfPirates.Missioni.Navi
{
    /// <summary>
    /// Classe astratta con funzioni e valori per il controllo dei nemici.
    /// </summary>
    public abstract class NaveNemico : Nave
    {
        internal Mazzo MazzoNave { get; set; }
        // raggio in cui la nave attacca
        private int dimTrigger;
        private int dobloni; //Ricompensa per il giocatore

        private int patrolIndex;
        private bool patrolInv;
        private Loc2D[] patrol; //Coordinate per il movimento
        private Image temp;

        //Le varianti: Mercantile, Fregata, Vascello (saranno definite tramite i parametri degli oggetti
        public NaveNemico(String nome_, Image immagine_, Stats stats_, Loc2D[] patrol) : base(nome_, immagine_, stats_, patrol[0])
        {
            this.patrol = patrol;
            //temp = missione.Mappa.Griglia_pictureBox[patrol[patrolIndex].X, patrol[patrolIndex].Y].BackgroundImage;
            temp = Properties.Resources.mare;
            dimTrigger = 2;
            patrolIndex = 0;
            patrolInv = false;
        }

        /// <summary>
        /// Attacca la nave specificata. in questo caso sarà sempre il giocatore.
        /// </summary>
        /// <param name="nave">Nave da attacare.</param>
        public override void Attacca(Nave nave)
        {
            int remPunti = new Random().Next(Stats.MinHit, Stats.MaxHit);
            nave.DecPuntiVita(remPunti);
        }

        /// <summary>
        /// Movimento specifico per i nemici secondo un percorso predefinito.
        /// </summary>
        /// <param name="missione">Missione in cui effetuare il movimento.</param>
        /// <param name="direzione">Direzione in cui effetuare il movimento.</param>
        public override void Movimento(Missione missione, Direzione direzione)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (Gioco.Giocatore.Loc.Equals(new Loc2D(i, j)));
                    {
                        Attacca(Gioco.Giocatore);
                        //return;
                    }
                }
            }
            Loc = patrol[patrolIndex];
            missione.Mappa.Griglia_pictureBox[patrol[patrolIndex].X, patrol[patrolIndex].Y].BackgroundImage = temp;
            if (patrolInv)
            {
                patrolIndex--;

                // Controlla se l'indice punta alla base dell'array di movimento
                // e nel caso accenda una flag che fa aumentare l'indice invece che diminuire
                if (patrolIndex <= 0)
                    patrolInv = false;
            }
            else
            {
                patrolIndex++;

                // Controlla se l'indice punta alla fine dell'array di movimento
                // e nel caso accenda una flag che fa diminuire l'indice invece che aumentare
                if (patrolIndex >= patrol.Length - 1)
                    patrolInv = true;
            }
            temp = missione.Mappa.Griglia_pictureBox[patrol[patrolIndex].X, patrol[patrolIndex].Y].BackgroundImage;
            missione.Mappa.Griglia_pictureBox[patrol[patrolIndex].X, patrol[patrolIndex].Y].BackgroundImage = immagine;
        }

        public void Affonda()
        {
            //
        }
    }
}
