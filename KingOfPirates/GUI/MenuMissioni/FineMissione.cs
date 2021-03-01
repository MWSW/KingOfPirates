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
    public partial class FineMissione : Form
    {
        public FineMissione(Ranking ranking)
        {
            InitializeComponent();

            Turni_label.Text = "TURNI: " + ranking.Turni;
            GameOver_label.Text = "GAMEOVER: " + ranking.GameOver;
            Rubini_label.Text = "RUBINI: " + ranking.Rubini;
            NaviAffondate_label.Text = "NAVI AFFONDATE: " + ranking.NaviAffondate;

            CartePerse_label.Text = "CARTE PERSE: " + Gioco.Giocatore.GiocatoreCarte.Mazzo.CarteMorte;

            //Calcolo del rank

            int score = 100;

            score -= (int)(ranking.Turni * 1.5f);
            score -= ranking.GameOver * 20;

            score += ranking.Rubini * 5;
            score += ranking.NaviAffondate * 30;

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
