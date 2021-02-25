using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates;
using KingOfPirates.Missioni;
using KingOfPirates.Missioni.Navi;
using KingOfPirates.Missioni.Roba;
using KingOfPirates.GUI.MenuPrincipale;
using KingOfPirates.GUI.MenuNassau;
using KingOfPirates.GUI.ScontroCarte;
using KingOfPirates.GUI.MenuMissioni;
using KingOfPirates.Cartina;

namespace KingOfPirates
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Gioco.Start();
            Application.Run();
        }
    }

    /// <summary>
    /// Classe per aiutare nell'avvio e terminazione del programma, da aggiornare per il programma finale
    /// </summary>

    static class Gioco
    {
        public static KingOfPirates.Missioni.Navi.NaveGiocatore Giocatore { get; set; }
        public static KingOfPirates.Cartina.GestioneDominio Dominio { get; set; }

        public static GUI.MenuPrincipale.StartMenu startMenu;
        public static GUI.MenuNassau.Nassau_form nassauForm;
        public static GUI.MenuMissioni.FormMissione menuMissioni;
        public static GUI.ScontroCarte.ScontroCarte scontroCarte;
        private static Task initTask = new Task(() =>
        {
            Console.WriteLine("#+ Inizializzazione con Task");
            //nassauForm = new GUI.MenuNassau.Nassau_form();

            Griglia griglia_prova = new Griglia(new int[19, 12] {{0,0,0,0,0,0,0,0,0,0,0,0},
                                                                 {0,0,0,0,2,2,2,0,0,0,0,0},
                                                                 {0,1,1,1,1,1,1,1,1,0,0,0},
                                                                 {0,0,1,1,1,1,1,1,0,0,0,0},
                                                                 {0,0,0,1,1,1,1,0,0,0,0,0},
                                                                 {0,0,0,0,1,1,0,0,0,0,0,0},
                                                                 {0,0,0,0,0,0,0,0,0,0,0,0},
                                                                 {0,0,0,0,0,0,2,0,0,0,0,0},
                                                                 {0,0,0,0,0,0,2,2,0,0,0,0},
                                                                 {0,0,0,0,0,0,0,0,0,0,0,0},
                                                                 {0,0,0,0,0,0,0,0,0,0,0,0},
                                                                 {0,0,0,0,0,0,0,0,0,0,0,0},
                                                                 {0,0,0,0,0,0,0,0,0,0,0,0},
                                                                 {0,0,0,0,0,0,0,0,0,0,0,0},
                                                                 {0,0,0,0,0,0,0,0,0,0,0,0},
                                                                 {0,0,0,0,0,0,0,0,0,0,0,0},
                                                                 {0,0,0,0,0,0,0,0,0,0,0,0},
                                                                 {0,0,0,0,0,0,0,0,0,0,0,0},
                                                                 {0,0,0,0,0,0,0,0,0,0,0,0}});

            menuMissioni = new GUI.MenuMissioni.FormMissione(new Missione(griglia_prova, new Loc2D(4, 4), new Loc2D(10, 10), 10));
            scontroCarte = new GUI.ScontroCarte.ScontroCarte();
            Console.WriteLine("#- Inizializzazione con Task");
        });

        public static void Start()
        {
            Giocatore = new NaveGiocatore("Nave da Test", Properties.Resources.nave_rossa, new Stats(), new Loc2D(), 5, 10, 20, 10);
            Dominio = new GestioneDominio();

            initTask.Start();
            startMenu = new StartMenu();
            startMenu.Show();
            initTask.Wait();
        }

        public static void End()
        {
            //nassauForm.Close();
            menuMissioni.Close();
            scontroCarte.Close();
            //nassauForm.Dispose();
            menuMissioni.Dispose();
            scontroCarte.Dispose();
            startMenu.Dispose();
            Application.Exit();
        }
    }
}
