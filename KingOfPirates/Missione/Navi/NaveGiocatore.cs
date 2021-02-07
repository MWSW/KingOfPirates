using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //Per le Bitmap
using KingOfPirates.Missione.Roba;

namespace KingOfPirates.Missione.Navi
{
    class NaveGiocatore : Nave
    {

        private bool staNavigando; //Verifica che sia su terreno o meno
        private int ubriachezza;

        //TO-FIX: Per ora Stats e Loc2D sono a zero
        public NaveGiocatore(String nome_, Bitmap immagine_) : base(nome_, immagine_, new Stats(), new Loc2D())
        {

        }
        public override void Movimento(Loc2D spostamento)
        {
            base.Movimento(spostamento);
        }

        public void Abborda(NaveNemico nave)
        {

        }
        public void Scavare() 
        {

        }

        //TO-DO: public void UsaOggetto(Oggetto o){}
    }
}
