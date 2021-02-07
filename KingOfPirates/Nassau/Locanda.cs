using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Per poter utilizzare la classe Bitmap
using System.Drawing;

namespace KingOfPirates.Nassau
{
    //Eredità componenti dalla classe padre Edificio
    class Locanda : Edificio
    {

        private int nSlot; //Posti letto disponibili (per le carte)
        private int detPerTurno; //Determinazione ripristinata per turno

        //TO-DO: Carta slotCarte[];


        //Fa riferimento al costruttore della sua superclasse
        public Locanda(Bitmap immagine_) : base("Locanda", immagine_) 
        {
            //TO-DO: slotCarte = new Carta[nSlot];
        }

        public override void Upgrade()
        {
            
        }

        public void curaCarte() { }

        //TO-DO: void ripristinaCarta(Carta carta){}

        public String scottaGerri() { return ""; } //non ho capito Emanuele (Ruben)
    }
}
