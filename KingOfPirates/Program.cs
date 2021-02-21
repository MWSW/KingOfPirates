using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates;
using KingOfPirates.GUI.MenuPrincipale;
using KingOfPirates.GUI.MenuNassau;
using KingOfPirates.GUI.ScontroCarte;
using KingOfPirates.GUI.MenuMissioni;

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

    // Classe per aiutare nell'avvio e terminazione del programma, da aggiornare per il programma finale

    static class Gioco
    {
        public static KingOfPirates.Missioni.Navi.NaveGiocatore Giocatore { get; set; }
        public static GUI.MenuPrincipale.StartMenu startMenu;
        public static GUI.MenuNassau.Nassau_form nassauForm;
        public static GUI.MenuMissioni.FormMissione menuMissioni;
        public static GUI.ScontroCarte.ScontroCarte scontroCarte;
        private static Task initTask = new Task(() =>
        {
            Console.WriteLine("#+ Inizio inizializzazione Forms con Task");
            nassauForm = new GUI.MenuNassau.Nassau_form();
            menuMissioni = new GUI.MenuMissioni.FormMissione(3, 3);
            scontroCarte = new GUI.ScontroCarte.ScontroCarte();
            Console.WriteLine("#- Fine inizializzazione Forms con Task");
        });

        public static void Start()
        {
            Giocatore = 
                new Missioni.Navi.NaveGiocatore("Nave da Test", Properties.Resources.nave_rossa, new Missioni.Roba.Stats(), new Missioni.Roba.Loc2D(), 0, 10);
            initTask.Start();
            startMenu = new GUI.MenuPrincipale.StartMenu();
            startMenu.Show();
            initTask.Wait();
        }

        public static void End()
        {
            nassauForm.Close();
            menuMissioni.Close();
            scontroCarte.Close();
            nassauForm.Dispose();
            menuMissioni.Dispose();
            scontroCarte.Dispose();
            startMenu.Dispose();
            Application.Exit();
        }
    }
}
