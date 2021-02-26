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
    /// <summary>
    /// Funzioni degli eventi del form FormMissione
    /// </summary>
    public partial class FormMissione : Form
    {
        internal Missione missione;
        internal Image temp;

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
            Gioco.Giocatore.Movimento(missione, Direzione.SOPRA);

            if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y] == 1)
                Scavo_button.Show();
            else
                Scavo_button.Hide();

        }

        private void Sotto_button_Click(object sender, EventArgs e)
        {
            Gioco.Giocatore.Movimento(missione, Direzione.SOTTO);

            if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y] == 1)
                Scavo_button.Show();
            else
                Scavo_button.Hide();
        }

        private void Sinistra_button_Click(object sender, EventArgs e)
        {
            Gioco.Giocatore.Movimento(missione, Direzione.SINISTRA);

            if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y] == 1)
                Scavo_button.Show();
            else
                Scavo_button.Hide();
        }

        private void Destra_button_Click(object sender, EventArgs e)
        {
            Gioco.Giocatore.Movimento(missione, Direzione.DESTRA);


            if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y] == 1)
                Scavo_button.Show();
            else
                Scavo_button.Hide();
        }

        private void Azione_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hai passato il turno!");
            Gioco.Giocatore.Stats.Pa = Gioco.Giocatore.Stats.Pa;
            EnergiaNave_label.Text = "Punti azione: " + Gioco.Giocatore.Stats.Pa + "/" + Gioco.Giocatore.Stats.PaMax; //aggiorna energia_label
        }

        private void Rum_button_Click(object sender, EventArgs e)
        {
            Gioco.Giocatore.Inventario.DecRum(); //consumi una unità di rum

            Gioco.Giocatore.IncUbriachezza(2); //aumenta l'ubriachezza

            //aggiorno label
            this.Rum_label.Text = "Rum rimasto: " + Gioco.Giocatore.Inventario.Rum;
            this.Ubriachezza_label.Text = "Ubriachezza: " + Gioco.Giocatore.Ubriachezza + "/" + Gioco.Giocatore.UbriachezzaMax;
        }

        private void AssLeg_button_Click(object sender, EventArgs e)
        {
            Gioco.Giocatore.Inventario.DecAssiLegno(); //consumi un'asse di legno

            Gioco.Giocatore.IncPuntiVita(3); //aumenta punti vita

            //aggiorno label
            this.AssLeg_label.Text = "Assi rimaste: " + Gioco.Giocatore.Inventario.AssiLegno;
            this.VitaNave_label.Text = "Punti Vita: " + Gioco.Giocatore.Stats.Hp + "/" + Gioco.Giocatore.Stats.HpMax;
        }

        private void BevandaDet_button_Click(object sender, EventArgs e)
        {
            Gioco.Giocatore.Inventario.DecBevandaDeterminazione(); //consumi una bevanda della determinazione

            Gioco.Giocatore.IncDeterminazione(2); //aumenta determinazione
            //aggiorno il label
            this.BevandaDet_label.Text = "Bevande Det Rimaste: " + Gioco.Giocatore.Inventario.BevandaDeterminazione;
            this.Determinazione_label.Text = "Determinazione: " + Gioco.Giocatore.Determinazione + "/" + Gioco.Giocatore.DeterminazioneMax;

        }

        private void AntiUbriachezza_button_Click(object sender, EventArgs e)
        {
            Gioco.Giocatore.Inventario.DecAntiUbriachezza(); //consumi una bevanda anti ubriachezza
            Gioco.Giocatore.DecUbriachezza(2); //diminuisce l'ubriachezza

            //aggiorno il label
            this.AntiUbriachezza_label.Text = "AntiUbriachezza rimasti: " + Gioco.Giocatore.Inventario.AntiUbriachezza;
            this.Ubriachezza_label.Text = "Ubriachezza: " + Gioco.Giocatore.Ubriachezza + "/" + Gioco.Giocatore.UbriachezzaMax;
        }

        private void Scavo_button_Click(object sender, EventArgs e)
        {
            if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y] != -1)
            {
                Random rand = new Random();

                int rng = rand.Next() * 100;

                if (rng < 70)
                    temp = Properties.Resources.cross; //sostituisco la texure sabbia con quella scavo
                else
                {
                    temp = Properties.Resources.ruby; //sostituisco la texure sabbia con rubino
                    Gioco.Dominio.CassaRubini++; //ottieni un rubino
                    this.Rubini_label.Text = "Rubini: " + Gioco.Dominio.CassaRubini;
                }

                //uso la matrice di inizializzazione per verificare se le celle sono già state scavate
                missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y] = -1;
                Scavo_button.Hide(); //la componente non serve più quindi la si nasconde
            }
        }

        private void MenuMissioni_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            Gioco.startMenu.Show();
        }
    }
}
