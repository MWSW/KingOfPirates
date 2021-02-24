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
        private Image immagine;
        private bool isGameOver;

        public Stats Stats { get; set; }
        public Loc2D Loc { get; set; }

        protected Nave(String nome_, Image immagine_, Stats stats_,  Loc2D loc_)
        {
            nome = nome_;
            immagine = immagine_;
            Stats = stats_;
            Loc = loc_;

            isGameOver = false; //la nave parte in vita
        }

        public virtual void Movimento(Loc2D spostamento) //(Virtual) indica che può essere esteso dai figli
        {
            //
        }

        public virtual void Attacca(Nave nave) 
        {

        }
    }
}
