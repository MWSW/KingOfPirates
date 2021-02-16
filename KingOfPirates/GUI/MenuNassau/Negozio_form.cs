using KingOfPirates.Nassau;
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
    public partial class Negozio_form : Form
    {
        Negozio negozio = new Negozio();
        GestioneDominio gestoreDominio;

        public Negozio_form(GestioneDominio gestoreDominio)
        {
            InitializeComponent();
            this.gestoreDominio = gestoreDominio;
        }

        private void back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Negozio_RiscattaTaglie_Button_Click(object sender, EventArgs e)
        {
            negozio.RiscattaTaglie(gestoreDominio);
        }

        private void Negozio_AcqBevDet_Button_Click(object sender, EventArgs e)
        {
            negozio.AcquistaBevandaDeterminazione(gestoreDominio);
        }

        private void Negozio_AcqRum_Button_Click(object sender, EventArgs e)
        {
            negozio.AcquistaRum(gestoreDominio);
        }

        private void Negozio_AcqBevAnt_Button_Click(object sender, EventArgs e)
        {
            negozio.AcquistaAntiubriachezza(gestoreDominio);
        }

        private void Negozio_AcqAssLeg_Button_Click(object sender, EventArgs e)
        {
            negozio.AcquistaAssiLegno(gestoreDominio);
        }

        private void Negozio_AcqCarte_Button_Click(object sender, EventArgs e)
        {
            negozio.AcquistaCarta();
        }
    }
}
