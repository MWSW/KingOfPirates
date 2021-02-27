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
using KingOfPirates.Missioni.Navi.Nemici.Generici;

/* L'Interfaccia grafica e' stata fatta a mano
 * La matrice e' stata pensata come piano cartesiano (x e y invertiti)
 * Corregerla richiede riscrivere la classe, che non ho intenzione di fare
 */

namespace KingOfPirates.GUI.MenuMissioni
{
    /// <summary>
    /// Form che rappresenta la griglia grafica della missione, fatto a mano.
    /// </summary>
    public partial class FormMissione : Form
    {
        internal Missione missione;
        internal Image temp;

        /// <summary>
        /// Costruttore, inizializza i componenti grafici.
        /// </summary>
        /// <param name="missione">Per manipolare la missione nel Form.</param>

        public FormMissione(Missione missione)
        {
            this.missione = missione;
            InitializeComponent(19, 12);

            Gioco.Giocatore.Loc.X = missione.PosNave.X; Gioco.Giocatore.Loc.Y = missione.PosNave.Y;
            temp = Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage;

            //stampa del giocatore
            //cambia immagine se è sopra una isola
            if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y + 1] == 1)
                Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Properties.Resources.omino;
            else
                Griglia_pictureBox[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y].BackgroundImage = Gioco.Giocatore.Immagine;

            //mostra nemici a schermo
            foreach(NaveNemico n in missione.Nemici)
            {
                Griglia_pictureBox[n.Loc.X, n.Loc.Y].BackgroundImage = n.Immagine;
            }
            
        }

        private void Update(Direzione dir)
        {
            Gioco.Giocatore.Movimento(missione, dir);

            //controlla vita nemici
            foreach (NaveNemico n in missione.Nemici)
            {
               if(n.Nemico_Carte.IsGameOver)
                    n.Affonda(missione);
            }

            //abbordaggio
            foreach (NaveNemico n in missione.Nemici)
            {
                if (Gioco.Giocatore.Loc.IsEqualTo(n.Loc) && !n.IsGameOver)
                {
                    MessageBox.Show("Hai abbordato una nave pirata!");
                    Gioco.Giocatore.Abborda(n);
                }
            }

            if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y] == 1)
                Scavo_button.Show();
            else
                Scavo_button.Hide();

            //bandiera (fine missione)
            if (missione.Griglia_numerica.Mat[Gioco.Giocatore.Loc.X, Gioco.Giocatore.Loc.Y] == 3)
            {
                //TEMP
                MessageBox.Show("Hai completato la missione!");
                //torna a nassau
                Gioco.nassauForm.Show();
                this.Hide();
            }
        }

        private void Sopra_button_Click(object sender, EventArgs e)
        {
            Update(Direzione.SOPRA);
        }

        private void Sotto_button_Click(object sender, EventArgs e)
        {
            Update(Direzione.SOTTO);
        }

        private void Sinistra_button_Click(object sender, EventArgs e)
        {
            Update(Direzione.SINISTRA);
        }

        private void Destra_button_Click(object sender, EventArgs e)
        {
            Update(Direzione.DESTRA);
        }

        private void Azione_button_Click(object sender, EventArgs e)
        {
            Gioco.Giocatore.Stats.Pa = Gioco.Giocatore.Stats.PaMax;
            EnergiaNave_label.Text = "Punti azione: " + Gioco.Giocatore.Stats.Pa + "/" + Gioco.Giocatore.Stats.PaMax; //aggiorna energia_label
            missione.TurnoNemico();

            //abbordaggio
            foreach (NaveNemico n in missione.Nemici)
            {
                if (Gioco.Giocatore.Loc.IsEqualTo(n.Loc) && !n.IsGameOver)
                {
                    MessageBox.Show("Il nemico ti ha abbordato!");
                    Gioco.Giocatore.Abborda(n);
                    n.IsGameOver = true;
                }
            }
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
