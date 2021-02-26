using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //Per le Bitmap
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using KingOfPirates.Missioni.Roba;

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
            temp = Properties.Resources.mare;
            dimTrigger = 2;
            patrolIndex = 0;
            patrolInv = false;
        }

        /// <summary>
        /// Movimento specifico per i nemici secondo un percorso predefinito
        /// </summary>
        /// <param name="missione"></param>
        /// <param name="direzione"></param>
        public override void Movimento(Missione missione, Direzione direzione)
        {
            // Controlla se l'indice punta alla fine dell'array di movimento
            // e nel caso accenda una flag che fa diminuire l'indice invece che aumentare
            if (patrolIndex > patrol.Length) patrolInv = true;
            else if (patrolIndex < 0) patrolInv = false;
            

            for (int i = 0; i < missione.Nemici.Length; i++)
            {
                if (this.Equals(missione.Nemici[i]))
                {
                    missione.Nemici[i].Loc = patrol[patrolIndex];
                    missione.Mappa.Griglia_pictureBox[patrol[patrolIndex].X, patrol[patrolIndex].Y].BackgroundImage = temp;
                    if (patrolInv)
                        patrolIndex--;
                    else
                        patrolIndex++;
                    temp = missione.Mappa.Griglia_pictureBox[patrol[patrolIndex].X, patrol[patrolIndex].Y].BackgroundImage;
                    missione.Mappa.Griglia_pictureBox[patrol[patrolIndex].X, patrol[patrolIndex].Y].BackgroundImage = immagine;
                }
                else continue;
            }
        }

        public void Affonda()
        {
            //
        }

        /// <summary>
        /// Funzione astratta della classe Nave, non implementata.
        /// Non serve perché il nemico non ha punti azione
        /// </summary>
        /// <param name="enTolta">Punti azione da togliere</param>
        public override void RemEnergia(int enTolta)
        {
            return;
        }
    }
}
