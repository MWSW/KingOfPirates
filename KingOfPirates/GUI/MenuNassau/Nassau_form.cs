using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates.Cartina;

namespace KingOfPirates.GUI.MenuNassau
{
    public partial class Nassau_form : Form
    {
        private Negozio_form negozio;
        private Locanda_form locanda;
        private Porto_form porto;

        private GestioneDominio gestoreDomino = new GestioneDominio();      //da spostare nel 'main' per renderlo utilizzabile anche dalla missione

        public Nassau_form()
        {
            InitializeComponent();
            negozio = new Negozio_form(gestoreDomino);
            locanda = new Locanda_form();
            porto = new Porto_form();
        }
        
        private void NegozioImgButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            negozio.Show();
        }

        private void LocandaImgButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            locanda.Show();
        }

        private void PortoImgButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            porto.Show();
        }
    }
}
