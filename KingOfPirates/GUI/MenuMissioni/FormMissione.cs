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
        private Image temp;

        public FormMissione(Missione missione)
        {
            this.missione = missione;
            InitializeComponent(19, 12);

            Gioco.Giocatore.Loc.X = missione.PosNave.X; Gioco.Giocatore.Loc.Y = missione.PosNave.Y;
            temp = Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage;


            //cambia immagine se è sopra una isola
            if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y + 1] == 1)
                Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.omino;
            else
                Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;
        }

        private void Sopra_button_Click(object sender, EventArgs e)
        {
            if (Gioco.Giocatore.Energia > 0) //Hai abbastanza energia
            {
                if (Gioco.Giocatore.Loc.Y - 1 < 0) return;
                if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y - 1] == 2) return;

                Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = temp; //texture vecchia
                Gioco.Giocatore.Loc.Y--; //aggiorno la posizione
                temp = Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage; //aggiorno temp
                Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.nave_pirata; //mostri nave

                Gioco.Giocatore.RemEnergia(1); //consumi energia
                this.EnergiaNave_label.Text = "Punti azione: " + Gioco.Giocatore.Energia + "/" + Gioco.Giocatore.EnergiaMax; //aggiorna energia_label
            }
            else
            {
                MessageBox.Show("Energia finita!");
                Gioco.Giocatore.Energia = Gioco.Giocatore.EnergiaMax; //ripristino energia
            }

        }

        private void Sotto_button_Click(object sender, EventArgs e)
        {
            if (Gioco.Giocatore.Energia > 0) //Hai abbastanza energia
            {
                if (Gioco.Giocatore.Loc.Y + 1 > 11) return;
                if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y + 1] == 2) return;

                Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = temp;
                Gioco.Giocatore.Loc.Y++;
                temp = Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage;

                //cambia immagine se è sopra una isola
                if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y + 1] == 1) 
                    Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.omino;
                else
                    Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;


                Gioco.Giocatore.RemEnergia(1); //consumi energia
                this.EnergiaNave_label.Text = "Punti azione: " + Gioco.Giocatore.Energia + "/" + Gioco.Giocatore.EnergiaMax; //aggiorna energia_label
            }
            else
            {
                MessageBox.Show("Energia finita!");
                Gioco.Giocatore.Energia = Gioco.Giocatore.EnergiaMax; //ripristino energia
            }
        }

        private void Sinistra_button_Click(object sender, EventArgs e)
        {
            if (Gioco.Giocatore.Energia > 0) //Hai abbastanza energia
            {
                //Controlli sulle posizioni
                if (Gioco.Giocatore.Loc.X - 1 < 0) return;
                if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X - 1, Gioco.Giocatore.Loc.Y] == 2) return;

                Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = temp;
                Gioco.Giocatore.Loc.X--;
                temp = Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage;

                if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y + 1] == 1) //isola
                    Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.omino;
                else
                    Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;


                Gioco.Giocatore.RemEnergia(1); //consumi energia
                this.EnergiaNave_label.Text = "Punti azione: " + Gioco.Giocatore.Energia + "/" + Gioco.Giocatore.EnergiaMax; //aggiorna energia_label
            }
            else
            {
                MessageBox.Show("Energia finita!");
                Gioco.Giocatore.Energia = Gioco.Giocatore.EnergiaMax; //ripristino energia
            }
        }

        private void Destra_button_Click(object sender, EventArgs e)
        {
            if (Gioco.Giocatore.Energia > 0) //Hai abbastanza energia
            {
                if (Gioco.Giocatore.Loc.X + 1 > 18) return;
                if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X + 1, Gioco.Giocatore.Loc.Y] == 2) return;

                Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = temp;
                Gioco.Giocatore.Loc.X++;
                temp = Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage;
                Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;


                if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y + 1] == 1) //isola
                    Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.omino;
                else
                    Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;


                Gioco.Giocatore.RemEnergia(1); //consumi energia
                this.EnergiaNave_label.Text = "Punti azione: " + Gioco.Giocatore.Energia + "/" + Gioco.Giocatore.EnergiaMax; //aggiorna energia_label
            }
            else
            {
                MessageBox.Show("Energia finita!");
                Gioco.Giocatore.Energia = Gioco.Giocatore.EnergiaMax; //ripristino energia
            }
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
