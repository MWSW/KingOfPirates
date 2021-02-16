using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Cartina
{
    public class GestioneDominio
    {
        private int dobloniPerTurno; //dobloni per turno
        private int cassaDobloni;
        private int cassaRubini;

        public GestioneDominio()
        {

        }

        public void AddTasse(int val)
        {
            dobloniPerTurno += val;
        }

        public void AddDobloni(int dobloni)
        {
            cassaDobloni += dobloni;
        }

        public void AddRubini(int rubini)
        {
            cassaRubini += rubini;
        }

        public void AddTaglieMercantile(int nTaglie)
        {
            taglieMercantile += nTaglie;
        }

        public void AddTaglieCaravella(int nTaglie)
        {
            taglieMercantile += nTaglie;
        }

        public void AddTaglieFregata(int nTaglie)
        {
            taglieMercantile += nTaglie;
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
