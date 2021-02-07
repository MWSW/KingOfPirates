using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Per poter usare la classe Bitmap
using System.Drawing;

namespace KingOfPirates.Nassau
{
    abstract class Edificio //L'oggetto Edificio non puo' essere creato
    {

        private string nome;
        private Bitmap immagine;


        protected Edificio(string nome_, Bitmap immagine_)
        {
            nome = nome_;
            immagine = immagine_;
        }

        public abstract void Upgrade(); //Sarà definito dalle classi figlie
    }
}
