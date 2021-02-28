using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingOfPirates.Mappa;
using KingOfPirates.Missioni.Navi;
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

            prezziOggetti[0] = 1;
            prezziOggetti[1] = 2;
            prezziOggetti[2] = 3;
            prezziOggetti[3] = 4;
        }

        public int getPrezziOggetti(int indice)
        {
            return prezziOggetti[indice];
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

        public void AcquistaBevandaDeterminazione(NaveGiocatore nave, GestioneDominio gest){
            if(gest.CassaDobloni >= prezziOggetti[0])
            {
                nave.Inventario.IncBevandaDeterminazione();
                gest.RemDobloni(prezziOggetti[0]);
            }
        }

        public void AcquistaRum(NaveGiocatore nave, GestioneDominio gest)
        {
            if(gest.CassaDobloni >= prezziOggetti[1])
            {
                nave.Inventario.IncRum();
                gest.RemDobloni(prezziOggetti[1]);
            }
        }
        
        public void AcquistaAntiubriachezza(NaveGiocatore nave, GestioneDominio gest)
        {
            if(gest.CassaDobloni >= prezziOggetti[2])
            {
                nave.Inventario.IncAntiUbriachezza();
                gest.RemDobloni(prezziOggetti[2]);
            }
        }

        public void AcquistaAssiLegno(NaveGiocatore nave, GestioneDominio gest)
        {
            if(gest.CassaDobloni >= prezziOggetti[3])
            {
                nave.Inventario.IncAssiLegno();
                gest.RemDobloni(prezziOggetti[3]);
            }
        }
        
        public void AcquistaCarta(GestioneDominio gestoreDominio){
            //gestoreDominio.RemDobloni(/*listaCarte.getCarta.getPrezzo*/);
            //listaCarte.getCarta().setUtilizzabile(true);
        }

        public override void Upgrade()
        {
            livelloNegozio ++;
        }
    }
}
