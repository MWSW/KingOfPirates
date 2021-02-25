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
using KingOfPirates.Mappa;
using KingOfPirates.Missioni.Navi;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using KingOfPirates.Missioni.ScontroCarte.Carte;

namespace KingOfPirates.GUI.MenuNassau
{
    public partial class Negozio_form : Form
    {
        Negozio negozio = new Negozio();

        private int currentIndex;

        public Negozio_form()
        {
            InitializeComponent();
            
            LoadData();
        }

        private void back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Negozio_RiscattaTaglie_Button_Click(object sender, EventArgs e)
        {
            negozio.RiscattaTaglie();
            UpdateOutput();
        }

        private void Negozio_AcqBevDet_Button_Click(object sender, EventArgs e)
        {
            negozio.AcquistaBevandaDeterminazione();
            UpdateOutput();
        }

        private void Negozio_AcqRum_Button_Click(object sender, EventArgs e)
        {
            negozio.AcquistaRum();
            UpdateOutput();
        }

        private void Negozio_AcqBevAnt_Button_Click(object sender, EventArgs e)
        {
            negozio.AcquistaAntiubriachezza();
            UpdateOutput();
        }

        private void Negozio_AcqAssLeg_Button_Click(object sender, EventArgs e)
        {
            negozio.AcquistaAssiLegno();
            UpdateOutput();
        }

        private void Negozio_AcqCarte_Button_Click(object sender, EventArgs e)
        {
            Negozio_acqCarte_Panel.Show();
        }

        private void backToNegozio_Button_Click(object sender, EventArgs e)
        {
            Negozio_acqCarte_Panel.Hide();
        }

        private void Seleziona()
        {
            Negozio_CarteInfo_Img.BackgroundImage = ListaCarte.GetCarta(currentIndex).Immagine;

            if (ListaCarte.GetCarta(currentIndex).Tipo == "attacco")
                Negozio_CarteAtk_Label.Text = "ATK: " + ((CartaBase)(ListaCarte.GetCarta(currentIndex))).Atk;
            else
                Negozio_CarteAtk_Label.Text = "ATK: -";

            if (ListaCarte.GetCarta(currentIndex).Tipo == "attacco")
                Negozio_CarteDef_Label.Text = "DEF: " + ((CartaBase)(ListaCarte.GetCarta(currentIndex))).Def;
            else
                Negozio_CarteDef_Label.Text = "DEF: -";

            if (ListaCarte.GetCarta(currentIndex).Tipo == "attacco")
            {
                if(((CartaBase)(ListaCarte.GetCarta(currentIndex))).Elemento == 'f')
                    Negozio_CarteElemento_Label.Text = "Elemento: FUOCO";
                else if(((CartaBase)(ListaCarte.GetCarta(currentIndex))).Elemento == 'g')
                    Negozio_CarteElemento_Label.Text = "Elemento: GHIACCIO";
                else if(((CartaBase)(ListaCarte.GetCarta(currentIndex))).Elemento == 's')
                    Negozio_CarteElemento_Label.Text = "Elemento: SASSO";
            }
            else
                Negozio_CarteElemento_Label.Text = "Elemento: - carta effetto -";

            Negozio_CarteDescrizione_Label.Text = "Descrizione: " + ListaCarte.GetCarta(currentIndex).Descrizione;

            Negozio_CartePossedute_Label.Text = "Possiedi " + "n" + " carte di questo tipo";    //TODO////////////////////////////////////
        }

        private void Negozio_CarteAcquista_Button_Click(object sender, EventArgs e)
        {
            Negozio_acqCarte_Panel.Show();
            negozio.AcquistaCarta(currentIndex);
            UpdateOutput();
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
            Negozio_CartePirata1_Label.Text = ListaCarte.GetCarta(0).Nome;
            Negozio_CartePirata2_Label.Text = ListaCarte.GetCarta(1).Nome;
            Negozio_CartePirata3_Label.Text = ListaCarte.GetCarta(2).Nome;
            Negozio_CartePirata4_Label.Text = ListaCarte.GetCarta(3).Nome;
            Negozio_CartePirata5_Label.Text = ListaCarte.GetCarta(4).Nome;
            Negozio_CartePirata6_Label.Text = ListaCarte.GetCarta(5).Nome;
            Negozio_CartePirata7_Label.Text = ListaCarte.GetCarta(6).Nome;
            Negozio_CartePirata8_Label.Text = ListaCarte.GetCarta(7).Nome;
            Negozio_CartePirata9_Label.Text = ListaCarte.GetCarta(8).Nome;
            Negozio_CartePirata10_Label.Text = ListaCarte.GetCarta(9).Nome;
            Negozio_CartePirata11_Label.Text = ListaCarte.GetCarta(10).Nome;
            Negozio_CartePirata12_Label.Text = ListaCarte.GetCarta(11).Nome;
            Negozio_CartePirata13_Label.Text = ListaCarte.GetCarta(12).Nome;
            Negozio_CartePirata14_Label.Text = ListaCarte.GetCarta(13).Nome;
            Negozio_CartePirata15_Label.Text = ListaCarte.GetCarta(14).Nome;
            Negozio_CartePirata16_Label.Text = ListaCarte.GetCarta(15).Nome;
            Negozio_CartePirata17_Label.Text = ListaCarte.GetCarta(16).Nome;
            Negozio_CartePirata18_Label.Text = ListaCarte.GetCarta(17).Nome;
            Negozio_CartePirata19_Label.Text = ListaCarte.GetCarta(18).Nome;
            Negozio_CartePirata20_Label.Text = ListaCarte.GetCarta(19).Nome;

            //Riga - prezzo
            Negozio_CartePrezzo1_Label.Text = ListaCarte.GetCarta(0).Prezzo.ToString();
            Negozio_CartePrezzo2_Label.Text = ListaCarte.GetCarta(1).Prezzo.ToString();
            Negozio_CartePrezzo3_Label.Text = ListaCarte.GetCarta(2).Prezzo.ToString();
            Negozio_CartePrezzo4_Label.Text = ListaCarte.GetCarta(3).Prezzo.ToString();
            Negozio_CartePrezzo5_Label.Text = ListaCarte.GetCarta(4).Prezzo.ToString();
            Negozio_CartePrezzo6_Label.Text = ListaCarte.GetCarta(5).Prezzo.ToString();
            Negozio_CartePrezzo7_Label.Text = ListaCarte.GetCarta(6).Prezzo.ToString();
            Negozio_CartePrezzo8_Label.Text = ListaCarte.GetCarta(7).Prezzo.ToString();
            Negozio_CartePrezzo9_Label.Text = ListaCarte.GetCarta(8).Prezzo.ToString();
            Negozio_CartePrezzo10_Label.Text = ListaCarte.GetCarta(9).Prezzo.ToString();
            Negozio_CartePrezzo11_Label.Text = ListaCarte.GetCarta(10).Prezzo.ToString();
            Negozio_CartePrezzo12_Label.Text = ListaCarte.GetCarta(11).Prezzo.ToString();
            Negozio_CartePrezzo13_Label.Text = ListaCarte.GetCarta(12).Prezzo.ToString();
            Negozio_CartePrezzo14_Label.Text = ListaCarte.GetCarta(13).Prezzo.ToString();
            Negozio_CartePrezzo15_Label.Text = ListaCarte.GetCarta(14).Prezzo.ToString();
            Negozio_CartePrezzo16_Label.Text = ListaCarte.GetCarta(15).Prezzo.ToString();
            Negozio_CartePrezzo17_Label.Text = ListaCarte.GetCarta(16).Prezzo.ToString();
            Negozio_CartePrezzo18_Label.Text = ListaCarte.GetCarta(17).Prezzo.ToString();
            Negozio_CartePrezzo19_Label.Text = ListaCarte.GetCarta(18).Prezzo.ToString();
            Negozio_CartePrezzo20_Label.Text = ListaCarte.GetCarta(19).Prezzo.ToString();

            //Riga - immagineTipo
            Negozio_CartaPirata1_Img.BackgroundImage = Properties.Resources.fuoco;
            Negozio_CartaPirata2_Img.BackgroundImage = Properties.Resources.ghiaccio;
            Negozio_CartaPirata3_Img.BackgroundImage = Properties.Resources.Sasso;
            Negozio_CartaPirata4_Img.BackgroundImage = Properties.Resources.Sasso;
            Negozio_CartaPirata5_Img.BackgroundImage = Properties.Resources.ghiaccio;
            Negozio_CartaPirata6_Img.BackgroundImage = Properties.Resources.fuoco;
            Negozio_CartaPirata7_Img.BackgroundImage = Properties.Resources.fuoco;
            Negozio_CartaPirata8_Img.BackgroundImage = Properties.Resources.fuoco;
            Negozio_CartaPirata9_Img.BackgroundImage = Properties.Resources.fuoco;
            Negozio_CartaPirata10_Img.BackgroundImage = Properties.Resources.fuoco;
            Negozio_CartaPirata11_Img.BackgroundImage = Properties.Resources.fuoco;
            Negozio_CartaPirata12_Img.BackgroundImage = Properties.Resources.fuoco;
            Negozio_CartaPirata13_Img.BackgroundImage = Properties.Resources.fuoco;
            Negozio_CartaPirata14_Img.BackgroundImage = Properties.Resources.fuoco;
            Negozio_CartaPirata15_Img.BackgroundImage = Properties.Resources.fuoco;
            Negozio_CartaPirata16_Img.BackgroundImage = Properties.Resources.curaPozione;
            Negozio_CartaPirata17_Img.BackgroundImage = Properties.Resources.curaEstesa;
            Negozio_CartaPirata18_Img.BackgroundImage = Properties.Resources.pow_buff;
            Negozio_CartaPirata19_Img.BackgroundImage = Properties.Resources.depotenziamento;
            Negozio_CartaPirata20_Img.BackgroundImage = Properties.Resources.sangue;

            UpdateOutput();
        }

        private void UpdateOutput()
        {
            Negozio_Fondi_Label.Text = (Gioco.Dominio.CassaDobloni).ToString() + " $";
            Negozio_CarteFondi_Label.Text = (Gioco.Dominio.CassaDobloni).ToString() + " $";

            Negozio_nBevDet_Label.Text = (Gioco.Giocatore.Inventario.BevandaDeterminazione).ToString();
            Negozio_nRum_Label.Text = (Gioco.Giocatore.Inventario.Rum).ToString();
            Negozio_nBevAnt_Label.Text = (Gioco.Giocatore.Inventario.AntiUbriachezza).ToString();
            Negozio_nAssLeg_Label.Text = (Gioco.Giocatore.Inventario.AssiLegno).ToString();

            Negozio_nTaglieMerc_Label.Text = "Taglie mercantili: " + (Gioco.Dominio.TaglieMercantile).ToString();
            Negozio_nTaglieCara_Label.Text = "Taglie caravelle: " + (Gioco.Dominio.TaglieCaravella).ToString();
            Negozio_nTaglieFreg_Label.Text = "Taglie fregate: " + (Gioco.Dominio.TaglieFregata).ToString();
        }


        //SELEZIONE CARTA - richiamo alla funzione seleziona

        private void Pirata1_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 0;
        }
        
        private void Negozio_CartePirata1_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 0;
        }
        
        private void Negozio_CartaPirata1_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 0;
        }
        
        private void Negozio_CartePrezzo1_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 0;
        }
        
        ///////////////////////////

        private void Pirata2_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 1;
        }
        
        private void Negozio_CartePirata2_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 1;
        }

        private void Negozio_CartaPirata2_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 1;
        }
        
        private void Negozio_CartePrezzo2_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 1;
        }

        ///////////////////////////
        
        private void Pirata3_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 2;
        }

        private void Negozio_CartePirata3_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 2;
        }
        
        private void Negozio_CartaPirata3_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 2;
        }
        
        private void Negozio_CartePrezzo3_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 2;
        }

        ///////////////////////////

        private void Pirata4_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 3;
        }
        
        private void Negozio_CartePirata4_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 3;
        }
        
        private void Negozio_CartaPirata4_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 3;
        }
        
        private void Negozio_CartePrezzo4_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 3;
        }

        ///////////////////////////

        private void Pirata5_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 4;
        }
        
        private void Negozio_CartePirata5_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 4;
        }
        
        private void Negozio_CartaPirata5_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 4;
        }

        private void Negozio_CartePrezzo5_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 4;
        }

        ///////////////////////////

        private void Pirata6_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 5;
        }
        
        private void Negozio_CartePirata6_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 5;
        }

        private void Negozio_CartaPirata6_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 5;
        }

        private void Negozio_CartePrezzo6_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 5;
        }

        ///////////////////////////

        private void Pirata7_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 6;
        }
        
        private void Negozio_CartePirata7_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 6;
        }

        private void Negozio_CartaPirata7_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 6;
        }

        private void Negozio_CartePrezzo7_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 6;
        }

        ///////////////////////////

        private void Pirata8_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 7;
        }
        
        private void Negozio_CartePirata8_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 7;
        }

        private void Negozio_CartaPirata8_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 7;
        }

        private void Negozio_CartePrezzo8_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 7;
        }

        ///////////////////////////

        private void Pirata9_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 8;
        }
        
        private void Negozio_CartePirata9_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 8;
        }

        private void Negozio_CartaPirata9_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 8;
        }

        private void Negozio_CartePrezzo9_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 8;
        }

        ///////////////////////////

        private void Pirata10_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 9;
        }
        
        private void Negozio_CartePirata10_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 9;
        }

        private void Negozio_CartaPirata10_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 9;
        }

        private void Negozio_CartePrezzo10_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 9;
        }

        ///////////////////////////

        private void Pirata11_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 10;
        }
        
        private void Negozio_CartePirata11_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 10;
        }

        private void Negozio_CartaPirata11_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 10;
        }

        private void Negozio_CartePrezzo11_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 10;
        }

        ///////////////////////////

        private void Pirata12_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 11;
        }
        
        private void Negozio_CartePirata12_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 11;
        }

        private void Negozio_CartaPirata12_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 11;
        }

        private void Negozio_CartePrezzo12_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 11;
        }

        ///////////////////////////

        private void Pirata13_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 12;
        }
        
        private void Negozio_CartePirata13_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 12;
        }

        private void Negozio_CartaPirata13_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 12;
        }

        private void Negozio_CartePrezzo13_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 12;
        }

        ///////////////////////////

        private void Pirata14_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 13;
        }
        
        private void Negozio_CartePirata14_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 13;
        }

        private void Negozio_CartaPirata14_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 13;
        }

        private void Negozio_CartePrezzo14_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 13;
        }

        ///////////////////////////

        private void Pirata15_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 14;
        }
        
        private void Negozio_CartePirata15_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 14;
        }

        private void Negozio_CartaPirata15_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 14;
        }

        private void Negozio_CartePrezzo15_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 14;
        }

        ///////////////////////////

        private void Pirata16_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 15;
        }
        
        private void Negozio_CartePirata16_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 15;
        }

        private void Negozio_CartaPirata16_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 15;
        }

        private void Negozio_CartePrezzo16_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 15;
        }

        ///////////////////////////

        private void Pirata17_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 16;
        }

        private void Negozio_CartePirata17_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 16;
        }

        private void Negozio_CartaPirata17_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 16;
        }

        private void Negozio_CartePrezzo17_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 16;
        }

        ///////////////////////////

        private void Pirata18_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 17;
        }

        private void Negozio_CartePirata18_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 17;
        }

        private void Negozio_CartaPirata18_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 17;
        }

        private void Negozio_CartePrezzo18_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 17;
        }

        ///////////////////////////

        private void Pirata19_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 18;
        }
        private void Negozio_CartePirata19_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 18;
        }

        private void Negozio_CartaPirata19_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 18;
        }

        private void Negozio_CartePrezzo19_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 18;
        }

        ///////////////////////////

        private void Pirata20_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 19;
        }
        
        private void Negozio_CartePirata20_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 19;
        }

        private void Negozio_CartaPirata20_Img_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 19;
        }

        private void Negozio_CartePrezzo20_Label_Click(object sender, EventArgs e)
        {
            Seleziona();
            currentIndex = 19;
        } 
    }
}
