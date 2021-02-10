using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Cartina
{
    class GestioneDominio
    {
        private int tasse; //dobloni per turno
        private int cassaDobloni;
        private int cassaRubini;

        public GestioneDominio()
        {
            //TODO
        }

        public void AddTasse(int val)
        {
            tasse += val;
        }

        public void AddDobloni(int dobloni)
        {
            cassaDobloni += dobloni;
        }

        public void AddRubini(int rubini)
        {
            cassaRubini += rubini;
        }

        public void RemDobloni(int dobloni)
        {
            cassaDobloni -= dobloni;
        }

        public void RemRubini(int rubini)
        {
            cassaRubini -= rubini;
        }

    }
}
