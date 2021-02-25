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
    /// <summary>
    /// Classe di ingresso principale.
    /// </summary>
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
    /// Classe che contiene variabili necessarie per il funzionamento del programma.
    /// </summary>
    static class Gioco
    {
        /// <summary>
        /// Proprietà rappresentante il giocatore
        /// </summary>
        public static KingOfPirates.Missioni.Navi.NaveGiocatore Giocatore { get; set; }
        public static KingOfPirates.Cartina.GestioneDominio Dominio { get; set; }
        public static Missione TestMissione { get; set; }

        public static GUI.MenuPrincipale.StartMenu startMenu;
        public static GUI.MenuNassau.Nassau_form nassauForm;
        public static GUI.MenuMissioni.FormMissione menuMissioni;
        public static GUI.ScontroCarte.ScontroCarte scontroCarte;
        /// <summary>
        /// Task asincrona per inizializzare componenti pesanti
        /// </summary>
        private static Task initTask = new Task(() =>
        {
            Console.WriteLine("#+ Inizializzazione con Task");
            // Il giocatore deve essere inizializzato per primo
            Giocatore = new NaveGiocatore("Nave da Test", Properties.Resources.nave_rossa, new Stats(), new Loc2D(), 5, 10);
            Dominio = new GestioneDominio();

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
            TestMissione = new Missione(griglia_prova, new Loc2D(3, 3), new Loc2D(10, 10), 5);

            scontroCarte = new GUI.ScontroCarte.ScontroCarte();
            nassauForm = new GUI.MenuNassau.Nassau_form();
            Console.WriteLine("#- Inizializzazione con Task");
        });

        public static void Start()
        {
            initTask.Start();
            startMenu = new StartMenu();
            startMenu.Show();
            initTask.Wait();
        }

        public static void End()
        {
            TestMissione.EndMissione();
            scontroCarte.Dispose();
            nassauForm.Dispose();
            startMenu.Dispose();
            Application.Exit();
        }
    }
}
