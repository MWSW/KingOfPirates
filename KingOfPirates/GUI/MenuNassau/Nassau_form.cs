using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates.Mappa;
using KingOfPirates.Missioni.Navi;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;

namespace KingOfPirates.GUI.MenuNassau
{
    public partial class Nassau_form : Form
    {
        private Negozio_form negozio;
        private Locanda_form locanda;
        private Porto_form porto;

        public Nassau_form()
        {
            InitializeComponent();

            negozio = new Negozio_form();
            locanda = new Locanda_form();
            porto = new Porto_form();
        }
        
        private void NegozioImgButton_Click(object sender, EventArgs e)
        {
            negozio.Show();
        }

        private void LocandaImgButton_Click(object sender, EventArgs e)
        {
            locanda.Show();
        }

        private void PortoImgButton_Click(object sender, EventArgs e)
        {
            porto.Show();
        }
    }
}
