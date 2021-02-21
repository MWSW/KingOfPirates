using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates.Missioni;

/* L'Interfaccia grafica e' stata fatta a mano
 * La matrice e' stata pensata come piano cartesiano (x e y invertiti)
 * Corregerla richiede riscrivere la classe, che non ho intenzione di fare
 */

namespace KingOfPirates.GUI.MenuMissioni
{
    public partial class FormMissione : Form
    {
        int xCorr, yCorr;
        public FormMissione()
        {
            InitializeComponent(19, 12);
            xCorr = 9; yCorr = 5;
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.nave_pirata;
        }

        private void Sopra_button_Click(object sender, EventArgs e)
        {
            if (yCorr - 1 < 0)
            {
                return;
            }
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.mare;
            yCorr--;
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.nave_pirata;
        }
        
        private void Sotto_button_Click(object sender, EventArgs e)
        {
            if (yCorr + 1 > 11)
            {
                return;
            }
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.mare;
            yCorr++;
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.nave_pirata;
        }

        private void Sinistra_button_Click(object sender, EventArgs e)
        {
            if (xCorr - 1 < 0)
            {
                return;
            }
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.mare;
            xCorr--;
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.nave_pirata;
        }

        private void Destra_button_Click(object sender, EventArgs e)
        {
            if (xCorr + 1 > 18)
            {
                return;
            }
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.mare;
            xCorr++;
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.nave_pirata;
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
