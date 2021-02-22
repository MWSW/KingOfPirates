using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates;
using KingOfPirates.Missioni;
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.Navi;

/* L'Interfaccia grafica e' stata fatta a mano
 * La matrice e' stata pensata come piano cartesiano (x e y invertiti)
 * Corregerla richiede riscrivere la classe, che non ho intenzione di fare
 */

namespace KingOfPirates.GUI.MenuMissioni
{
    public partial class FormMissione : Form
    {
        private Missione missione;

        public FormMissione(Missione missione)
        {
            InitializeComponent(19, 12);
            this.missione = missione;
            Gioco.Giocatore.Loc.X = missione.PosNave.X; Gioco.Giocatore.Loc.Y = missione.PosNave.Y;
            Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;
        }

        private void Sopra_button_Click(object sender, EventArgs e)
        {
            if (Gioco.Giocatore.Loc.Y - 1 < 0)
            {
                return;
            }
            Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.mare;
            Gioco.Giocatore.Loc.Y--;
            Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;
        }

        private void Sotto_button_Click(object sender, EventArgs e)
        {
            if (Gioco.Giocatore.Loc.Y + 1 > 11)
            {
                return;
            }
            Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.mare;
            Gioco.Giocatore.Loc.Y++;
            Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;
        }

        private void Sinistra_button_Click(object sender, EventArgs e)
        {
            if (Gioco.Giocatore.Loc.X - 1 < 0)
            {
                return;
            }
            Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.mare;
            Gioco.Giocatore.Loc.X--;
            Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;
        }

        private void Destra_button_Click(object sender, EventArgs e)
        {
            if (Gioco.Giocatore.Loc.X + 1 > 18)
            {
                return;
            }
            Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.mare;
            Gioco.Giocatore.Loc.X++;
            Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;
        }

        private void Azione_button_Click(object sender, EventArgs e)
        {
            Gioco.Giocatore.Energia = 10;
        }

        private void Rum_button_Click(object sender, EventArgs e)
        {
            //
        }

        private void AssLeg_button_Click(object sender, EventArgs e)
        {
            //
        }

        private void BevandaDet_button_Click(object sender, EventArgs e)
        {
            //
        }

        private void AntiUbriachezza_button_Click(object sender, EventArgs e)
        {
            //
        }

        private void MenuMissioni_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            Gioco.startMenu.Show();
        }

        private void Griglia_ErrorBox()
        {
            const string message = "Non puoi andare in quella direzione";
            const string caption = "Avviso";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Exclamation);
        }
    }
}
