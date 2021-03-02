using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Per poter utilizzare la classe Bitmap
using System.Drawing;
using KingOfPirates.Missioni.ScontroCarte.Carte;

namespace KingOfPirates.Nassau
{
    //Eredità componenti dalla classe padre Edificio
    class Locanda : Edificio
    {

        //private int nSlot;                              //Posti letto disponibili (per le carte)
        //private int detPerTurno;                        //Determinazione ripristinata per turno

        //Carta[] slotCarte;


        //Fa riferimento al costruttore della sua superclasse
        public Locanda() 
        {
            nome = "Locanda";
        }

        public override void Upgrade()
        {
            
        }

        public void CuraCarte() { }

        public void RipristinaCarta(Carta carta){}

        public String ScottaGerri() { return ""; }      //non ho Iuri (Ruben)
    }
}
