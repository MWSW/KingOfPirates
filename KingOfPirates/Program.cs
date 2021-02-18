using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates;
using KingOfPirates.GUI.MenuPrincipale;
using KingOfPirates.GUI.MenuNassau;
using KingOfPirates.GUI.ScontroCarte;
using KingOfPirates.GUI.Missioni;

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

    // Classe per aiutare nell'avvio e terminazione del programma

    static class Gioco
    {
        public static GUI.MenuPrincipale.StartMenu startMenu;
        public static GUI.MenuNassau.Nassau_form nassauForm;
        public static GUI.Missioni.MenuMissioni menuMissioni;
        public static GUI.ScontroCarte.ScontroCarte scontroCarte;

        public static void Start()
        {
            startMenu = new GUI.MenuPrincipale.StartMenu();
            nassauForm = new GUI.MenuNassau.Nassau_form();
            menuMissioni = new GUI.Missioni.MenuMissioni();
            scontroCarte = new GUI.ScontroCarte.ScontroCarte();
            startMenu.Show();
        }

        public static void End()
        {
            startMenu.Close();
            nassauForm.Close();
            menuMissioni.Close();
            scontroCarte.Close();
            startMenu.Dispose();
            nassauForm.Dispose();
            menuMissioni.Dispose();
            scontroCarte.Dispose();
            Application.Exit();
        }
    }
}
