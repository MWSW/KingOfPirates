using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingOfPirates.Mappa;
using KingOfPirates.Missioni.Navi;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;
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

        public void RiscattaTaglie(){
            int taglieMerca = Gioco.Dominio.TaglieMercantile;            //assegnazione del numero di taglie per tipo
            int taglieCarav = Gioco.Dominio.TaglieCaravella;
            int taglieFrega = Gioco.Dominio.TaglieFregata;

            int valoreMerca = 1;                                //valore per tipo di taglia
            int valoreCarav = 1;
            int valoreFrega = 1;

            Gioco.Dominio.AddDobloni(taglieMerca * valoreMerca);         //riscossione taglia, aggiunta dobloni alla cassa
            Gioco.Dominio.AddDobloni(taglieCarav * valoreCarav);
            Gioco.Dominio.AddDobloni(taglieFrega * valoreFrega);

            Gioco.Dominio.TaglieMercantile = 0;                          //reset nTaglie
            Gioco.Dominio.TaglieCaravella = 0;
            Gioco.Dominio.TaglieFregata = 0;
        }

        public void AcquistaBevandaDeterminazione(){
            if(Gioco.Dominio.CassaDobloni >= prezziOggetti[0])
            {
                Gioco.Giocatore.Inventario.IncBevandaDeterminazione();
                Gioco.Dominio.RemDobloni(prezziOggetti[0]);
            }
        }

        public void AcquistaRum()
        {
            if(Gioco.Dominio.CassaDobloni >= prezziOggetti[1])
            {
                Gioco.Giocatore.Inventario.IncRum();
                Gioco.Dominio.RemDobloni(prezziOggetti[1]);
            }
        }
        
        public void AcquistaAntiubriachezza()
        {
            if(Gioco.Dominio.CassaDobloni >= prezziOggetti[2])
            {
                Gioco.Giocatore.Inventario.IncAntiUbriachezza();
                Gioco.Dominio.RemDobloni(prezziOggetti[2]);
            }
        }

        public void AcquistaAssiLegno()
        {
            if(Gioco.Dominio.CassaDobloni >= prezziOggetti[3])
            {
                Gioco.Giocatore.Inventario.IncAssiLegno();
                Gioco.Dominio.RemDobloni(prezziOggetti[3]);
            }
        }
        
        public void AcquistaCarta(int indice){
            Gioco.Dominio.RemDobloni(ListaCarte.GetCartaClone(indice).Prezzo);
            ListaCarte.GetCarta(indice).SetUtilizzabile(true);

            ListaCarte.GetCarta(indice).MaxDeterminazione(); //carta con determinazione massima
        }

        public override void Upgrade()
        {
            livelloNegozio ++;
        }
    }
}
