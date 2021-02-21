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

// Sto facendo l'interfaccia a mano e non è finita

namespace KingOfPirates.GUI.MenuMissioni
{
    public partial class FormMissione : Form
    {
        int xCorr, yCorr;
        public FormMissione()
        {
            InitializeComponent(19, 12);
            xCorr = 10; yCorr = 6;
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.nave_pirata;
        }

        private void Sopra_button_Click(object sender, EventArgs e)
        {
            if (yCorr + 1 > 19 || yCorr - 1 < 0 || xCorr + 1 > 12 || xCorr - 1 < 0)
            {
                return;
            }
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.mare;
            yCorr--;
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.nave_pirata;
        }

        private void Sinistra_button_Click(object sender, EventArgs e)
        {
            if (yCorr + 1 > 19 || yCorr - 1 < 0 || xCorr + 1 > 12 || xCorr - 1 < 0)
            {
                return;
            }
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.mare;
            xCorr--;
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.nave_pirata;
        }

        private void Sotto_button_Click(object sender, EventArgs e)
        {
            if (yCorr + 1 > 19 || yCorr - 1 < 0 || xCorr + 1 > 12 || xCorr - 1 < 0)
            {
                return;
            }
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.mare;
            yCorr++;
            Griglia_pictureBox[xCorr, yCorr].BackgroundImage = Properties.Resources.nave_pirata;
        }

        private void Destra_button_Click(object sender, EventArgs e)
        {
            if (yCorr + 1 > 19 || yCorr - 1 < 0 || xCorr + 1 > 12 || xCorr - 1 < 0)
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
