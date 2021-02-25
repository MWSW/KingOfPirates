using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Drawing; //Per le Bitmap
using KingOfPirates.Missioni.Roba;

namespace KingOfPirates.Missioni.Navi
{
    public class NaveNemico : Nave
    {
        private int dimensioneTrigger;
        private int dobloni; //Ricompensa per il giocatore

        private Loc2D coordPartol; //Coordinate per il movimento 

        //Le varianti: Mercantile, Fregata, Vascello (saranno definite tramite i parametri degli oggetti
        public NaveNemico(String nome_, Bitmap immagine_, Stats stats_, Loc2D loc_) : base(nome_, immagine_, stats_, loc_)
        {
            //
        }

        public override void Movimento(Loc2D spostamento)
        {
            base.Movimento(spostamento);
        }

        public void Affonda()
        {
            
        }
    }
}
