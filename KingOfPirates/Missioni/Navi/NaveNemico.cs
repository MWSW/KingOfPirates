using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //Per le Bitmap
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.ScontroCarte.Carte;

namespace KingOfPirates.Missioni.Navi
{
    /// <summary>
    /// Classe astratta con funzioni e valori per il controllo dei nemici.
    /// </summary>
    public abstract class NaveNemico : Nave
    {
        internal Nemico_carte Nemico_Carte { get; set; }
        // raggio in cui la nave attacca
        private int dimTrigger;
        private int dobloni; //Ricompensa per il giocatore

        private int patrolIndex;
        private bool patrolInv;
        private Loc2D[] patrol; //Coordinate per il movimento

        public bool IsGameOver { get; set; }

        //Le varianti: Mercantile, Fregata, Vascello (saranno definite tramite i parametri degli oggetti
        public NaveNemico(String nome_, Image immagine_, Stats stats_, Loc2D[] patrol, Nemico_carte nemico_Carte) : base(nome_, immagine_, stats_, patrol[0])
        {
            this.patrol = patrol;
            this.Nemico_Carte = nemico_Carte;
            dimTrigger = 2;
            patrolIndex = 0;
            patrolInv = false;

            IsGameOver = false;
        }

        /// <summary>
        /// Movimento specifico per i nemici secondo un percorso predefinito
        /// </summary>
        /// <param name="missione">Missione in cui effetuare il movimento.</param>
        /// <param name="direzione">Direzione in cui effetuare il movimento</param>
        public override void Movimento(Missione missione, Direzione direzione)
        {
            if (Attacca(missione, Gioco.Giocatore)) return;
            if (!IsGameOver)
            {
                missione.Mappa.Griglia_pictureBox[patrol[patrolIndex].X, patrol[patrolIndex].Y].BackgroundImage = Properties.Resources.mare;
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
                //aggiorna posizione
                missione.Mappa.Griglia_pictureBox[patrol[patrolIndex].X, patrol[patrolIndex].Y].BackgroundImage = Immagine;
                Loc = patrol[patrolIndex];
            }
        }

        /// <summary>
        /// Attacca la nave specificata nella missione specificata.
        /// </summary>
        /// <param name="nave">Nave da attaccare.</param>
        /// <param name="missione">Missione in cui attaccare</param>
        public override bool Attacca(Missione missione, Nave nave)
        {
            for (int i = -dimTrigger + 1; i < dimTrigger; i++)
            {
                for (int j = -dimTrigger + 1; j < dimTrigger; j++)
                {
                    Loc2D tempLoc = new Loc2D(i + Loc.X, j + Loc.Y);
                    if (tempLoc.IsEqualTo(Gioco.Giocatore.Loc))
                    {
                        int remPunti = new Random().Next(Stats.MinHit, Stats.MaxHit);
                        nave.DecPuntiVita(remPunti);
                        missione.Mappa.UpdateComponenti();
                        return true;
                    }
                }
            }
            return false;
        }

        public void Affonda(Missione missione)
        {
            //missione.Mappa.Griglia_pictureBox[Loc.X, Loc.Y].BackgroundImage = Properties.Resources.mare;
            IsGameOver = true;
        }
    }
}
