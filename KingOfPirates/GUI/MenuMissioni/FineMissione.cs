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
        public FineMissione(Ranking ranking)
        {
            InitializeComponent();

            Turni_label.Text = "TURNI: " + ranking.Turni;
            GameOver_label.Text = "GAMEOVER: " + ranking.GameOver;
            Rubini_label.Text = "RUBINI: " + ranking.Rubini;
            NaviAffondate_label.Text = "NAVI AFFONDATE: " + ranking.NaviAffondate;

            //Calcolo del rank

            int score = 120;

            score -= (int)(ranking.Turni * 1.5f);
            score -= ranking.GameOver * 20;

            score += ranking.Rubini * 5;
            score += ranking.NaviAffondate * 30;

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

            this.Close();
        }
    }
}
