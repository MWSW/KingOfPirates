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

namespace KingOfPirates.GUI.Missioni
{
    public partial class MenuMissioni : Form
    {
        Griglia griglia;

        public MenuMissioni()
        {
            InitializeComponent(36);
        }

        private void Sopra_button_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void Sinistra_button_Click(object sender, EventArgs e)
        {
            //Griglia_flowLayoutPanel.GetChildAtPoint(Griglia_pictureBox.Location);
            Griglia_flowLayoutPanel.Controls.Find("Griglia_pictureBox.Image",false);
        }

        private void Sotto_button_Click(object sender, EventArgs e)
        {

        }

        private void Destra_button_Click(object sender, EventArgs e)
        {

        }
    }
}
