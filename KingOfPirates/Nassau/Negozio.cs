using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //Per le Bitmap

namespace KingOfPirates.Nassau
{
    class Negozio : Edificio
    {

        private int livelloNegozio; //salva il livello degli upgrade
        private int[] prezziOggetti;

        public Negozio()
        {
            livelloNegozio = 0;
            nome = "Negozio";
            prezziOggetti = new int[4];
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

        public void AcquistaBevandaDeterminazione(NaveGiocatore nave){
            //incrementa il numero di bevante
        }

        public void AcquistaRum(NaveGiocatore nave)
        {
            //incrementa il numero di bottiglie di rum
        }
        
        public void AcquistaAntiubriachezza(NaveGiocatore nave)
        {
            //incrementa il numero di antiubriachezza
        }

        public void AcquistaAssiLegno(NaveGiocatore nave)
        {
            //incrementa il numero di assi di legno
        }
        
        public void AcquistaCarta(){
            //...
        }

        public override void Upgrade()
        {
            livelloNegozio ++;
        }
    }
}
