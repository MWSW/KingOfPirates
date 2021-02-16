using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;   //Per poter usare la classe Bitmap

namespace KingOfPirates.Nassau
{
    abstract class Edificio //L'oggetto Edificio non puo' essere creato
    {

        protected string nome;
        protected Bitmap immagine;


        protected Edificio()
        {

        }

        public abstract void Upgrade();     //Sarà definito dalle classi figlie
    }
}
