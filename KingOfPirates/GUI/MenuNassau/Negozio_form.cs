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
using KingOfPirates.Missioni.Navi;

namespace KingOfPirates.GUI.MenuNassau
{
    public partial class Negozio_form : Form
    {
        Negozio negozio = new Negozio();
        GestioneDominio gestoreDominio;
        NaveGiocatore naveGiocatore;

        public Negozio_form(GestioneDominio gestoreDominio, NaveGiocatore naveGiocatore)
        {
            InitializeComponent();
            
            this.gestoreDominio = gestoreDominio;
            this.naveGiocatore = naveGiocatore;
            
            LoadData();
        }

        private void back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Negozio_RiscattaTaglie_Button_Click(object sender, EventArgs e)
        {
            negozio.RiscattaTaglie(gestoreDominio);
            UpdateOutput();
        }

        private void Negozio_AcqBevDet_Button_Click(object sender, EventArgs e)
        {
            negozio.AcquistaBevandaDeterminazione(naveGiocatore, gestoreDominio);
            UpdateOutput();
        }

        private void Negozio_AcqRum_Button_Click(object sender, EventArgs e)
        {
            negozio.AcquistaRum(naveGiocatore, gestoreDominio);
            UpdateOutput();
        }

        private void Negozio_AcqBevAnt_Button_Click(object sender, EventArgs e)
        {
            negozio.AcquistaAntiubriachezza(naveGiocatore, gestoreDominio);
            UpdateOutput();
        }

        private void Negozio_AcqAssLeg_Button_Click(object sender, EventArgs e)
        {
            negozio.AcquistaAssiLegno(naveGiocatore, gestoreDominio);
            UpdateOutput();
        }

        private void Negozio_AcqCarte_Button_Click(object sender, EventArgs e)
        {
            Negozio_acqCarte_Panel.Show();
            negozio.AcquistaCarta();
            UpdateOutput();
        }

        private void backToNegozio_Button_Click(object sender, EventArgs e)
        {
            Negozio_acqCarte_Panel.Hide();
        }

        private void LoadData()
        {
            Negozio_CostoBevDet_Label.Text = (negozio.getPrezziOggetti(0)).ToString() + " $";
            Negozio_CostoRum_Label.Text = (negozio.getPrezziOggetti(1)).ToString() + " $";
            Negozio_CostoBevAnt_Label.Text = (negozio.getPrezziOggetti(2)).ToString() + " $";
            Negozio_CostoAssLeg_Label.Text = (negozio.getPrezziOggetti(3)).ToString() + " $";

            UpdateOutput();
        }

        private void UpdateOutput()
        {
            Negozio_Fondi_Label.Text = (gestoreDominio.CassaDobloni).ToString() + " $";

            Negozio_nBevDet_Label.Text = (naveGiocatore.Inventario.BevandaDeterminazione).ToString();
            Negozio_nRum_Label.Text = (naveGiocatore.Inventario.Rum).ToString();
            Negozio_nBevAnt_Label.Text = (naveGiocatore.Inventario.AntiUbriachezza).ToString();
            Negozio_nAssLeg_Label.Text = (naveGiocatore.Inventario.AssiLegno).ToString();

            Negozio_nTaglieMerc_Label.Text = "Taglie mercantili: " + (gestoreDominio.TaglieMercantile).ToString();
            Negozio_nTaglieCara_Label.Text = "Taglie caravelle: " + (gestoreDominio.TaglieCaravella).ToString();
            Negozio_nTaglieFreg_Label.Text = "Taglie fregate: " + (gestoreDominio.TaglieFregata).ToString();
        }
    }
}
