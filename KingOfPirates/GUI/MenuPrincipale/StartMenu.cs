using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates.GUI.MenuNassau;

namespace KingOfPirates.GUI.MenuPrincipale
{
    /// <summary>
    /// Menu principale dell'app
    /// </summary>
    public partial class StartMenu : Form
    {
        private MenuNassau.Nassau_form NassauForm { get; set; }
        public StartMenu()
        {
            InitializeComponent();
            NassauForm = new Nassau_form();
        }

        private void Nassau_button_Click(object sender, EventArgs e)
        {
            Gioco.nassauForm.Show();
            this.Hide();
        }

        private void Missioni_button_Click(object sender, EventArgs e)
        {
            Gioco.TestMissione.StartMissione();
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

        private void Start_button_Click(object sender, EventArgs e)
        {
            NassauForm.Show();
        }

        private void Crediti_button_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Gioco.End();
        }
    }
}
