using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingOfPirates.GUI.MenuPrincipale
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void Nassau_button_Click(object sender, EventArgs e)
        {
            Gioco.nassauForm.Show();
            this.Hide();
        }

        private void Missioni_button_Click(object sender, EventArgs e)
        {
            Gioco.TestMissione.Mappa.Show();
            this.Hide();
        }

        private void ScontroCarte_button_Click(object sender, EventArgs e)
        {
            Gioco.scontroCarte.Show();
            this.Hide();
        }

        private void StartMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Gioco.End();
        }
    }
}
