﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates;
using KingOfPirates.GUI.MenuPrincipale;
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
            //new StartMenu().Show();
            new MenuMissioni().Show();
            Application.Run();
        }
    }
}
