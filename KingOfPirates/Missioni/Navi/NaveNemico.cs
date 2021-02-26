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
    public abstract class NaveNemico : Nave
    {
        internal Mazzo MazzoNave { get; set; }
        // raggio in cui la nave attacca
        private int dimTrigger;
        private int dobloni; //Ricompensa per il giocatore

        private int patrolIndex;
        private bool patrolInv;
        private Loc2D[] patrol; //Coordinate per il movimento

        //Le varianti: Mercantile, Fregata, Vascello (saranno definite tramite i parametri degli oggetti
        public NaveNemico(String nome_, Image immagine_, Stats stats_, Loc2D loc_, Loc2D[] patrol) : base(nome_, immagine_, stats_, loc_)
        {
            this.patrol = patrol;
            dimTrigger = 2;
            patrolIndex = 0;
            patrolInv = false;
        }

        public override void Movimento(Missione missione, Direzione direzione)
        {
            throw new NotImplementedException();
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
