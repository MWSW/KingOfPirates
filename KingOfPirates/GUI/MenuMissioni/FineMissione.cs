using KingOfPirates.Missioni;
using KingOfPirates.Missioni.ScontroCarte.Carte;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingOfPirates.GUI.MenuMissioni
{
    /// <summary>
    /// Classe che mostra al giocatore la sua performance.
    /// Gestisce la fine della missione chiamando Missione.EndMissione()
    /// </summary>
    public partial class FineMissione : Form
    {
        Missione missione;
        /// <summary>
        /// Costruttore che accetta la missione per cui mostrare la performance
        /// </summary>
        /// <param name="missione"></param>
        public FineMissione(Missione missione)
        {
            InitializeComponent();
            this.missione = missione;
        }

        private void FineMissione_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnClick(sender, e);
        }

        private void FineMissione_Shown(object sender, EventArgs e)
        {
            Turni_label.Text = "TURNI: " + missione.Ranking.Turni;
            GameOver_label.Text = "GAMEOVER: " + missione.Ranking.GameOver;
            Rubini_label.Text = "RUBINI: " + missione.Ranking.Rubini;
            NaviAffondate_label.Text = "NAVI AFFONDATE: " + missione.Ranking.NaviAffondate;

            CartePerse_label.Text = "CARTE PERSE: " + Gioco.Giocatore.GiocatoreCarte.Mazzo.CarteMorte;

            //Calcolo del rank

            int score = 100;

            score -= (int)(missione.Ranking.Turni * 1.5f);
            score -= missione.Ranking.GameOver * 20;

            score += missione.Ranking.Rubini * 5;
            score += missione.Ranking.NaviAffondate * 30;

            score -= Gioco.Giocatore.GiocatoreCarte.Mazzo.CarteMorte*10;

            if (score >= 90)
                Rank_label.Text = "S";
            else if (score >= 75)
                Rank_label.Text = "A";
            else if (score >= 60)
                Rank_label.Text = "B";
            else if (score >= 50)
                Rank_label.Text = "C";
            else
                Rank_label.Text = "D";
        }

        private void OnClick(object sender, EventArgs e)
        {

            //le carte cher riposavano alla locanda si risvegliano dal loro sonno
            //la loro determinazione torna massima
            for(int i = 0; i < ListaCarte.GetLength(); i++)
            {
                if(ListaCarte.GetCarta(i).IsSleeping == true)
                {
                    ListaCarte.GetCarta(i).MaxDeterminazione();
                    ListaCarte.GetCarta(i).SetUtilizzabile(true);
                    ListaCarte.GetCarta(i).IsSleeping = false;
                }
            }

            //non aggiorna alla locanda

            //torna a Nassau
            Gioco.nassauForm.GetLocanda_Form().Reset(); //reset visivo
            Gioco.nassauForm.Show();
            this.Close();
        }
    }
}
