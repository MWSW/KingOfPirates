using KingOfPirates.GUI.MenuNassau;
using KingOfPirates.GUI.MenuPrincipale;
using KingOfPirates.GUI.ScontroCarte;
using KingOfPirates.Mappa;
using KingOfPirates.Missioni;
using KingOfPirates.Missioni.Navi;
using KingOfPirates.Missioni.Navi.Nemici.Generici;
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.ScontroCarte.Carte;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using KingOfPirates.Properties;
using System;
using System.Windows.Forms;

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
        public static StartMenu startMenu;

        public static Nassau_form nassauForm;

        //public static GUI.MenuMissioni.FormMissione menuMissioni;
        public static ScontroCarte scontroCarte;

        /// <summary>
        /// Proprietà rappresentante il giocatore
        /// </summary>
        public static NaveGiocatore Giocatore { get; set; }

        public static GestioneDominio Dominio { get; set; }
        public static Missione TestMissione { get; set; }

        /// <summary>
        /// Avviatore dell'applicazione
        /// </summary>
        public static void Start()
        {
            Init();
            startMenu = new StartMenu();
            startMenu.Show();
        }

        /// <summary>
        /// Terminatore dell'applicazione
        /// </summary>
        public static void End()
        {
            TestMissione.EndMissione();
            scontroCarte.Dispose();
            nassauForm.Dispose();
            startMenu.Dispose();
            Application.Exit();
        }

        private static void Init()
        {
            Console.WriteLine("#+ Inizializzazione");
            // Il giocatore deve essere inizializzato per primo

            Carta[] carte_player =
            {
                ListaCarte.GetCartaClone(1),
                ListaCarte.GetCartaClone(2), ListaCarte.GetCartaClone(3), ListaCarte.GetCartaClone(4),
                ListaCarte.GetCartaClone(5), ListaCarte.GetCartaClone(6), ListaCarte.GetCartaClone(17),
                ListaCarte.GetCartaClone(18), ListaCarte.GetCartaClone(19)
            };


            Player_carte player_prova = new Player_carte(10, new Mazzo(carte_player));

            Giocatore = new NaveGiocatore("Nave da Test", Resources.nave_rossa, new Stats(), new Loc2D(3, 3),
                5, 10, player_prova);
            Dominio = new GestioneDominio();

            Griglia griglia_prova = new Griglia(new int[19, 12]
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

            NaveNemico[] testNemici = new NaveNemico[3];
            Loc2D[] testPatrol = new Loc2D[] {new Loc2D(6, 6), new Loc2D(6, 7), new Loc2D(7, 7)};
            Loc2D[] testPatrol2 = new Loc2D[] {new Loc2D(10, 10), new Loc2D(10, 9), new Loc2D(9, 9)};
            Loc2D[] testPatrol3 = new Loc2D[] {new Loc2D(13, 8), new Loc2D(12, 8), new Loc2D(11, 8), new Loc2D(11, 7)};

            Nemico_carte nemico_prova = new Nemico_carte(10, Resources.pub,
                new Carta[] {ListaCarte.GetCarta(1)}, "ErNemiko!");
            Nemico_carte nemico_prova1 = new Nemico_carte(10, Resources.pub,
                new Carta[] {ListaCarte.GetCarta(2)}, "ErNemiko2!");
            Nemico_carte nemico_prova2 = new Nemico_carte(10, Resources.pub,
                new Carta[] {ListaCarte.GetCarta(3)}, "ErNemiko3!");

            testNemici[0] = new Mercantile(new Stats(), testPatrol, nemico_prova);
            testNemici[1] = new Caravella(new Stats(), testPatrol2, nemico_prova1);
            testNemici[2] = new Fregata(new Stats(), testPatrol3, nemico_prova2);
            TestMissione = new Missione(griglia_prova, 5, testNemici);

            scontroCarte = new ScontroCarte(nemico_prova);
            nassauForm = new Nassau_form();
            Console.WriteLine("#- Inizializzazione");
        }
    }
}