using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //per le Bitmap
using KingOfPirates.Missioni.Navi;
using KingOfPirates.Cartina;

namespace KingOfPirates.Nassau
{
    class Porto : Edificio
    {
        //Attributi per gli upgrade
        private int livelloCannoni;
        private int livelloVele;
        private int livelloScafo;

        private int livelloPorto;

        private int[] prezzoCannoni;
        private int[] prezzoScafo;
        private int[] prezzoVele;

        public Porto()
        {
            nome = "Porto";
            livelloPorto = 0;
            LivelloCannoni = 0;
            LivelloVele = 0;
            LivelloScafo = 0;

            PrezzoCannoni = new int[3];
            PrezzoScafo = new int[3];
            PrezzoVele = new int[3];

            PrezzoCannoni[0] = 55;
            PrezzoScafo[0] = 45;
            PrezzoVele[0] = 52;

            PrezzoCannoni[1] = 120;
            PrezzoScafo[1] = 100;
            PrezzoVele[1] = 110;

            PrezzoCannoni[2] = 200;
            PrezzoScafo[2] = 180;
            PrezzoVele[2] = 190;
        }
        public int LivelloCannoni { get => livelloCannoni; set => livelloCannoni = value; }
        public int LivelloVele { get => livelloVele; set => livelloVele = value; }
        public int LivelloScafo { get => livelloScafo; set => livelloScafo = value; }
        public int[] PrezzoCannoni { get => prezzoCannoni; set => prezzoCannoni = value; }
        public int[] PrezzoScafo { get => prezzoScafo; set => prezzoScafo = value; }
        public int[] PrezzoVele { get => prezzoVele; set => prezzoVele = value; }

        public void Salpa() 
        {

        }

        public void PotenziaCannoni() {
            if(LivelloCannoni <= 3)
            {
                Gioco.Dominio.RemDobloni(PrezzoCannoni[LivelloCannoni]);
                LivelloCannoni ++;
            }
        }

        public void PotenziaVele() {
            if (LivelloVele <= 3)
            {
                Gioco.Dominio.RemDobloni(PrezzoVele[LivelloVele]);
                LivelloVele ++;
            }
        }

        public void PotenziaScafo() {
            if (LivelloScafo <= 3)
            {
                Gioco.Dominio.RemDobloni(PrezzoScafo[LivelloScafo]);
                LivelloScafo ++;
            }
        }

        public override void Upgrade()
        {
            
        }
    }
}
