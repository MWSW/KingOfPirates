using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingOfPirates.Cartina;
using KingOfPirates.Missioni.Navi;

using System.Drawing; //Per le Bitmap

namespace KingOfPirates.Nassau
{
    class Negozio : Edificio
    {

        private int livelloNegozio; //salva il livello degli upgrade

        public Negozio(Bitmap immagine_) : base("Negozio", immagine_)
        {
            livelloNegozio = 0;
        }

        public void RiscattaTaglie(GestioneDominio gest){
            int taglieMerca = gest.TaglieMercantile;            //assegnazione del numero di taglie per tipo
            int taglieCarav = gest.TaglieCaravella;
            int taglieFrega = gest.TaglieFregata;

            int valoreMerca = 1;                                //valore per tipo di taglia
            int valoreCarav = 1;
            int valoreFrega = 1;

            gest.AddDobloni(taglieMerca * valoreMerca);         //riscossione taglia, aggiunta dobloni alla cassa
            gest.AddDobloni(taglieCarav * valoreCarav);
            gest.AddDobloni(taglieFrega * valoreFrega);

            gest.TaglieMercantile = 0;                          //reset nTaglie
            gest.TaglieCaravella = 0;
            gest.TaglieFregata = 0;
        }

        public void AcquistaBevandaDeterminazione(NaveGiocatore player){
            
        }

        //TODO: public void AcquistaRum(Player p){}
        //TODO: public void AcquistaAntiubriachezza(Player p){}
        //TODO: public void AcquistaAssiLegno(Player p){}
        //TODO: public void AcquistaCarta(Player p, Carta c){}

        public override void Upgrade()
        {

        }
    }
}
