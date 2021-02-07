using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //per le Bitmap

namespace KingOfPirates.Nassau
{
    class Porto : Edificio
    {
        //Attributi per gli upgrade
        private int livelloCannoni;
        private int livelloVele;
        private int livelloScafo;

        private int livelloPorto;

        public Porto(Bitmap immagine_) : base("Porto", immagine_)
        {

        }

        public void Salpa() 
        {

        }

        //TO-DO: public void PotenziaCannoni(Nave nave) { }
        //TO-DO: public void PotenziaVele(Nave nave) { }
        //TO-DO: public void PotenziaScafo(Nave nave) { }

        public override void Upgrade()
        {
            
        }
    }
}
