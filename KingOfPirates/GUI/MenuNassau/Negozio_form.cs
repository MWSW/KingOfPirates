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
using KingOfPirates.Missioni.ScontroCarte.Opponenti;

namespace KingOfPirates.GUI.MenuNassau
{
    public partial class Negozio_form : Form
    {
        Negozio negozio = new Negozio();
        GestioneDominio gestoreDominio;
        NaveGiocatore naveGiocatore;
        ListaCarte listaCarte;

        public Negozio_form(GestioneDominio gestoreDominio, NaveGiocatore naveGiocatore, ListaCarte listaCarte)
        {
            InitializeComponent();
            
            this.gestoreDominio = gestoreDominio;
            this.naveGiocatore = naveGiocatore;
            this.listaCarte = listaCarte;
            
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
            //Negozio principale
            Negozio_CostoBevDet_Label.Text = (negozio.getPrezziOggetti(0)).ToString() + " $";
            Negozio_CostoRum_Label.Text = (negozio.getPrezziOggetti(1)).ToString() + " $";
            Negozio_CostoBevAnt_Label.Text = (negozio.getPrezziOggetti(2)).ToString() + " $";
            Negozio_CostoAssLeg_Label.Text = (negozio.getPrezziOggetti(3)).ToString() + " $";

            //Negozio carte

            //Riga - nome
            Negozio_CartePirata1_Label.Text = ;
            Negozio_CartePirata2_Label.Text = ;
            Negozio_CartePirata3_Label.Text = ;
            Negozio_CartePirata4_Label.Text = ;
            Negozio_CartePirata5_Label.Text = ;
            Negozio_CartePirata6_Label.Text = ;
            Negozio_CartePirata7_Label.Text = ;
            Negozio_CartePirata8_Label.Text = ;
            Negozio_CartePirata9_Label.Text = ;
            Negozio_CartePirata10_Label.Text = ;
            Negozio_CartePirata11_Label.Text = ;
            Negozio_CartePirata12_Label.Text = ;
            Negozio_CartePirata13_Label.Text = ;
            Negozio_CartePirata14_Label.Text = ;
            Negozio_CartePirata15_Label.Text = ;
            Negozio_CartePirata16_Label.Text = ;
            Negozio_CartePirata17_Label.Text = ;
            Negozio_CartePirata18_Label.Text = ;
            Negozio_CartePirata19_Label.Text = ;
            Negozio_CartePirata20_Label.Text = ;

            //Riga - prezzo
            Negozio_CartePrezzo1_Label.Text = ;
            Negozio_CartePrezzo2_Label.Text = ;
            Negozio_CartePrezzo3_Label.Text = ;
            Negozio_CartePrezzo4_Label.Text = ;
            Negozio_CartePrezzo5_Label.Text = ;
            Negozio_CartePrezzo6_Label.Text = ;
            Negozio_CartePrezzo7_Label.Text = ;
            Negozio_CartePrezzo8_Label.Text = ;
            Negozio_CartePrezzo9_Label.Text = ;
            Negozio_CartePrezzo10_Label.Text = ;
            Negozio_CartePrezzo11_Label.Text = ;
            Negozio_CartePrezzo12_Label.Text = ;
            Negozio_CartePrezzo13_Label.Text = ;
            Negozio_CartePrezzo14_Label.Text = ;
            Negozio_CartePrezzo15_Label.Text = ;
            Negozio_CartePrezzo16_Label.Text = ;
            Negozio_CartePrezzo17_Label.Text = ;
            Negozio_CartePrezzo18_Label.Text = ;
            Negozio_CartePrezzo19_Label.Text = ;
            Negozio_CartePrezzo20_Label.Text = ;

            //Riga - immagineTipo
            Negozio_CartaPirata1_Img.Image = ;
            Negozio_CartaPirata2_Img.Image = ;
            Negozio_CartaPirata3_Img.Image = ;
            Negozio_CartaPirata4_Img.Image = ;
            Negozio_CartaPirata5_Img.Image = ;
            Negozio_CartaPirata6_Img.Image = ;
            Negozio_CartaPirata7_Img.Image = ;
            Negozio_CartaPirata8_Img.Image = ;
            Negozio_CartaPirata9_Img.Image = ;
            Negozio_CartaPirata10_Img.Image = ;
            Negozio_CartaPirata11_Img.Image = ;
            Negozio_CartaPirata12_Img.Image = ;
            Negozio_CartaPirata13_Img.Image = ;
            Negozio_CartaPirata14_Img.Image = ;
            Negozio_CartaPirata15_Img.Image = ;
            Negozio_CartaPirata16_Img.Image = ;
            Negozio_CartaPirata17_Img.Image = ;
            Negozio_CartaPirata18_Img.Image = ;
            Negozio_CartaPirata19_Img.Image = ;
            Negozio_CartaPirata20_Img.Image = ;

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
