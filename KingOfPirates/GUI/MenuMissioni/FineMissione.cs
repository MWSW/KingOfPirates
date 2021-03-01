using KingOfPirates.Missioni;
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
    public partial class FineMissione : Form
    {
        Missione missione;
        public FineMissione(Missione missione)
        {
            InitializeComponent();
            this.missione = missione;

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

            score -= Gioco.Giocatore.GiocatoreCarte.Mazzo.CarteMorte*2;

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
            //torna a Nassau
            Gioco.nassauForm.Show();

            Close();
        }

        private void FineMissione_FormClosing(object sender, FormClosingEventArgs e)
        {
            missione.EndMissione();
        }
    }
}
