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
        private int taglieMercantile;
        private int taglieCaravella;
        private int taglieFregata;

        public GestioneDominio()
        {
            cassaDobloni = 0;
            cassaRubini = 0;
            taglieMercantile = 0;
            taglieCaravella = 0;
            taglieFregata = 0;
        }

        public int TaglieMercantile { get => taglieMercantile; set => taglieMercantile = value; }

        public int TaglieCaravella { get => taglieCaravella; set => taglieCaravella = value; }

        public int TaglieFregata { get => taglieFregata; set => taglieFregata = value; }

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
