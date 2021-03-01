using KingOfPirates.Missioni.Navi;
using KingOfPirates.Missioni.Navi.Nemici.Generici;
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.ScontroCarte.Carte;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using KingOfPirates.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingOfPirates.Missioni
{
    /// <summary>
    /// Raccolta di missioni prefatte
    /// </summary>
    abstract class ListaMissioni
    {
        private static Missione Missione1()
        {
            Griglia griglia = new Griglia(new int[19, 12]
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 2, 2, 2, 0, 0, 0, 0, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0},
                {0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
                {0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            });

            //Lista nemici
            NaveNemico[] testNemici = new NaveNemico[3];
            Loc2D[] testPatrol = new Loc2D[] { new Loc2D(6, 6), new Loc2D(6, 7), new Loc2D(7, 7) };
            Loc2D[] testPatrol2 = new Loc2D[] { new Loc2D(10, 10), new Loc2D(10, 9), new Loc2D(9, 9) };
            Loc2D[] testPatrol3 = new Loc2D[] { new Loc2D(13, 8), new Loc2D(12, 8), new Loc2D(11, 8), new Loc2D(11, 7) };

            Nemico_carte nemico_prova = new Nemico_carte(10, Resources.pub,
                new Carta[] { ListaCarte.GetCarta(1) }, "ErNemiko!");
            Nemico_carte nemico_prova1 = new Nemico_carte(10, Resources.pub,
                new Carta[] { ListaCarte.GetCarta(2) }, "ErNemiko2!");
            Nemico_carte nemico_prova2 = new Nemico_carte(10, Resources.pub,
                new Carta[] { ListaCarte.GetCarta(3) }, "ErNemiko3!");

            testNemici[0] = new Mercantile(new Stats(), testPatrol, nemico_prova);
            testNemici[1] = new Caravella(new Stats(), testPatrol2, nemico_prova1);
            testNemici[2] = new Fregata(new Stats(), testPatrol3, nemico_prova2);


            //genera la missione
            return new Missione(griglia, 5, testNemici);
        }

        private static Missione Missione2()
        {
            Griglia griglia = new Griglia(new int[19, 12]
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 2, 2, 2, 0, 0, 0, 0, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0},
                {0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
                {0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                {0, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            });

            //Lista nemici
            NaveNemico[] testNemici = new NaveNemico[3];
            Loc2D[] testPatrol = new Loc2D[] { new Loc2D(6, 6), new Loc2D(6, 7), new Loc2D(7, 7) };
            Loc2D[] testPatrol2 = new Loc2D[] { new Loc2D(10, 10), new Loc2D(10, 9), new Loc2D(9, 9) };
            Loc2D[] testPatrol3 = new Loc2D[] { new Loc2D(13, 8), new Loc2D(12, 8), new Loc2D(11, 8), new Loc2D(11, 7) };

            Nemico_carte nemico_prova = new Nemico_carte(10, Resources.pub,
                new Carta[] { ListaCarte.GetCarta(1) }, "ErNemiko!");
            Nemico_carte nemico_prova1 = new Nemico_carte(10, Resources.pub,
                new Carta[] { ListaCarte.GetCarta(2) }, "ErNemiko2!");
            Nemico_carte nemico_prova2 = new Nemico_carte(10, Resources.pub,
                new Carta[] { ListaCarte.GetCarta(3) }, "ErNemiko3!");

            testNemici[0] = new Mercantile(new Stats(), testPatrol, nemico_prova);
            testNemici[1] = new Caravella(new Stats(), testPatrol2, nemico_prova1);
            testNemici[2] = new Fregata(new Stats(), testPatrol3, nemico_prova2);


            //genera la missione
            return new Missione(griglia, 5, testNemici);
        }

        private static Missione Missione3()
        {
            Griglia griglia = new Griglia(new int[19, 12]
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 2, 2, 2, 0, 0, 0, 0, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0},
                {0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
                {0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0},
                {0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 2, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            });

            //Lista nemici
            NaveNemico[] testNemici = new NaveNemico[3];
            Loc2D[] testPatrol = new Loc2D[] { new Loc2D(6, 6), new Loc2D(6, 7), new Loc2D(7, 7) };
            Loc2D[] testPatrol2 = new Loc2D[] { new Loc2D(10, 10), new Loc2D(10, 9), new Loc2D(9, 9) };
            Loc2D[] testPatrol3 = new Loc2D[] { new Loc2D(13, 8), new Loc2D(12, 8), new Loc2D(11, 8), new Loc2D(11, 7) };

            Nemico_carte nemico_prova = new Nemico_carte(10, Resources.pub,
                new Carta[] { ListaCarte.GetCarta(1) }, "ErNemiko!");
            Nemico_carte nemico_prova1 = new Nemico_carte(10, Resources.pub,
                new Carta[] { ListaCarte.GetCarta(2) }, "ErNemiko2!");
            Nemico_carte nemico_prova2 = new Nemico_carte(10, Resources.pub,
                new Carta[] { ListaCarte.GetCarta(3) }, "ErNemiko3!");

            testNemici[0] = new Mercantile(new Stats(), testPatrol, nemico_prova);
            testNemici[1] = new Caravella(new Stats(), testPatrol2, nemico_prova1);
            testNemici[2] = new Fregata(new Stats(), testPatrol3, nemico_prova2);


            //genera la missione
            return new Missione(griglia, 5, testNemici);
        }

        /// <summary>
        /// Getter per ottenere una missione
        /// </summary>
        /// <param name="index">Indice della missione</param>
        /// <returns>La missione specificata</returns>
        public static Missione GetMissione(int index)
        {
            switch(index)
            {
                case 0:
                    return Missione1();
                case 1:
                    return Missione2();
                case 2:
                    return Missione3();
                default:
                    MessageBox.Show("Errore nessuna missione trovata con questo indice!");
                    return null;
            }
        }
    }
}
