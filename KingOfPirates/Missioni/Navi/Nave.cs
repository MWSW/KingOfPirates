using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //Per le Bitmap


using KingOfPirates.Missioni.Roba;

namespace KingOfPirates.Missioni.Navi
{
    public abstract class Nave
    {
        private string nome;
        private Bitmap immagine;
        private bool isGameOver;

        private Stats stats;
        private Loc2D loc;

        protected Nave(String nome_, Bitmap immagine_, Stats stats_,  Loc2D loc_)
        {
            nome = nome_;
            immagine = immagine_;
            stats = stats_;
            loc = loc_;

            isGameOver = false; //la nave parte in vita
        }

        public virtual void Movimento(Loc2D spostamento) //(Virtual) indica che può essere esteso dai figli
        {
            //
        }

        public void Attacca(Nave nave) 
        {

        }
    }
}
