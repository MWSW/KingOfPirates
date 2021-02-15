using KingOfPirates.GUI.ScontroCarte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using KingOfPirates;
using KingOfPirates.GUI.MenuPrincipale;
=======
//using KingOfPirates.GUI.MenuPrincipale;


>>>>>>> Ruben

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
<<<<<<< HEAD
            new StartMenu().Show();
=======
            //new StartMenu().Show();
            new ScontroCarte().Show();
>>>>>>> Ruben
            Application.Run();
        }
    }
}
