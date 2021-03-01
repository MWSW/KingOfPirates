using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates.Nassau;
using KingOfPirates.Mappa;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;

namespace KingOfPirates.GUI.MenuNassau
{
    public partial class Locanda_form : Form
    {
        Locanda locanda = new Locanda();
        private int indiceCartaSelezionata;

        public Locanda_form()
        {
            InitializeComponent();

            Update();
        }

        private void Locanda_Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void Update()
        {

            Locanda_Carta1_Panel.BackgroundImage = ListaCarte.GetCarta(0).Immagine;
            Locanda_Carta2_Panel.BackgroundImage = ListaCarte.GetCarta(1).Immagine;
            Locanda_Carta3_Panel.BackgroundImage = ListaCarte.GetCarta(2).Immagine;
            Locanda_Carta4_Panel.BackgroundImage = ListaCarte.GetCarta(3).Immagine;
            Locanda_Carta5_Panel.BackgroundImage = ListaCarte.GetCarta(4).Immagine;
            Locanda_Carta6_Panel.BackgroundImage = ListaCarte.GetCarta(5).Immagine;
            Locanda_Carta7_Panel.BackgroundImage = ListaCarte.GetCarta(6).Immagine;
            Locanda_Carta8_Panel.BackgroundImage = ListaCarte.GetCarta(7).Immagine;
            Locanda_Carta9_Panel.BackgroundImage = ListaCarte.GetCarta(8).Immagine;
            Locanda_Carta10_Panel.BackgroundImage = ListaCarte.GetCarta(9).Immagine;
            Locanda_Carta11_Panel.BackgroundImage = ListaCarte.GetCarta(10).Immagine;
            Locanda_Carta12_Panel.BackgroundImage = ListaCarte.GetCarta(11).Immagine;
            Locanda_Carta13_Panel.BackgroundImage = ListaCarte.GetCarta(12).Immagine;
            Locanda_Carta14_Panel.BackgroundImage = ListaCarte.GetCarta(13).Immagine;
            Locanda_Carta15_Panel.BackgroundImage = ListaCarte.GetCarta(14).Immagine;
            Locanda_Carta16_Panel.BackgroundImage = ListaCarte.GetCarta(15).Immagine;
            Locanda_Carta17_Panel.BackgroundImage = ListaCarte.GetCarta(16).Immagine;
            Locanda_Carta18_Panel.BackgroundImage = ListaCarte.GetCarta(17).Immagine;
            Locanda_Carta19_Panel.BackgroundImage = ListaCarte.GetCarta(18).Immagine;
            Locanda_Carta20_Panel.BackgroundImage = ListaCarte.GetCarta(19).Immagine;

            showHideUtilizzabile(Locanda_Carta1_Panel, 0);
            showHideUtilizzabile(Locanda_Carta2_Panel, 1);
            showHideUtilizzabile(Locanda_Carta3_Panel, 2);
            showHideUtilizzabile(Locanda_Carta4_Panel, 3);
            showHideUtilizzabile(Locanda_Carta5_Panel, 4);
            showHideUtilizzabile(Locanda_Carta6_Panel, 5);
            showHideUtilizzabile(Locanda_Carta7_Panel, 6);
            showHideUtilizzabile(Locanda_Carta8_Panel, 7);
            showHideUtilizzabile(Locanda_Carta9_Panel, 8);
            showHideUtilizzabile(Locanda_Carta10_Panel, 9);
            showHideUtilizzabile(Locanda_Carta11_Panel, 10);
            showHideUtilizzabile(Locanda_Carta12_Panel, 11);
            showHideUtilizzabile(Locanda_Carta13_Panel, 12);
            showHideUtilizzabile(Locanda_Carta14_Panel, 13);
            showHideUtilizzabile(Locanda_Carta15_Panel, 14);
            showHideUtilizzabile(Locanda_Carta16_Panel, 15);
            showHideUtilizzabile(Locanda_Carta17_Panel, 16);
            showHideUtilizzabile(Locanda_Carta18_Panel, 17);
            showHideUtilizzabile(Locanda_Carta19_Panel, 18);
            showHideUtilizzabile(Locanda_Carta20_Panel, 19);

            Locanda_Det1_Label.Text = (ListaCarte.GetCarta(0).Determinazione).ToString();
            Locanda_Det2_Label.Text = (ListaCarte.GetCarta(1).Determinazione).ToString();
            Locanda_Det3_Label.Text = (ListaCarte.GetCarta(2).Determinazione).ToString();
            Locanda_Det4_Label.Text = (ListaCarte.GetCarta(3).Determinazione).ToString();
            Locanda_Det5_Label.Text = (ListaCarte.GetCarta(4).Determinazione).ToString();
            Locanda_Det6_Label.Text = (ListaCarte.GetCarta(5).Determinazione).ToString();
            Locanda_Det7_Label.Text = (ListaCarte.GetCarta(6).Determinazione).ToString();
            Locanda_Det8_Label.Text = (ListaCarte.GetCarta(7).Determinazione).ToString();
            Locanda_Det9_Label.Text = (ListaCarte.GetCarta(8).Determinazione).ToString();
            Locanda_Det10_Label.Text = (ListaCarte.GetCarta(9).Determinazione).ToString();
            Locanda_Det11_Label.Text = (ListaCarte.GetCarta(10).Determinazione).ToString();
            Locanda_Det12_Label.Text = (ListaCarte.GetCarta(11).Determinazione).ToString();
            Locanda_Det13_Label.Text = (ListaCarte.GetCarta(12).Determinazione).ToString();
            Locanda_Det14_Label.Text = (ListaCarte.GetCarta(13).Determinazione).ToString();
            Locanda_Det15_Label.Text = (ListaCarte.GetCarta(14).Determinazione).ToString();
            Locanda_Det16_Label.Text = (ListaCarte.GetCarta(15).Determinazione).ToString();
            Locanda_Det17_Label.Text = (ListaCarte.GetCarta(16).Determinazione).ToString();
            Locanda_Det18_Label.Text = (ListaCarte.GetCarta(17).Determinazione).ToString();
            Locanda_Det19_Label.Text = (ListaCarte.GetCarta(18).Determinazione).ToString();
            Locanda_Det20_Label.Text = (ListaCarte.GetCarta(19).Determinazione).ToString();
        }

        private void showHideUtilizzabile(Control component, int indice)                     //se la carta non è utilizzabile la nasconde
        {
            if (!(ListaCarte.GetCarta(indice).GetUtilizzabile()))
                component.Hide();
        }


        //////////////////////////////DRAG

        private void Locanda_Carta1_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 0;
            Locanda_Carta1_Panel.DoDragDrop(Locanda_Carta1_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta2_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 1;
            Locanda_Carta2_Panel.DoDragDrop(Locanda_Carta2_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta3_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 2;
            Locanda_Carta3_Panel.DoDragDrop(Locanda_Carta3_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta4_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 3;
            Locanda_Carta4_Panel.DoDragDrop(Locanda_Carta4_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta5_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 4;
            Locanda_Carta5_Panel.DoDragDrop(Locanda_Carta5_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta6_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 5;
            Locanda_Carta6_Panel.DoDragDrop(Locanda_Carta6_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta7_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 6;
            Locanda_Carta7_Panel.DoDragDrop(Locanda_Carta7_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta8_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 7;
            Locanda_Carta8_Panel.DoDragDrop(Locanda_Carta8_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta9_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 8;
            Locanda_Carta9_Panel.DoDragDrop(Locanda_Carta9_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta10_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 9;
            Locanda_Carta10_Panel.DoDragDrop(Locanda_Carta10_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta11_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 10;
            Locanda_Carta11_Panel.DoDragDrop(Locanda_Carta11_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta12_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 11;
            Locanda_Carta12_Panel.DoDragDrop(Locanda_Carta12_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta13_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 12;
            Locanda_Carta13_Panel.DoDragDrop(Locanda_Carta13_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta14_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 13;
            Locanda_Carta14_Panel.DoDragDrop(Locanda_Carta14_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta15_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 14;
            Locanda_Carta15_Panel.DoDragDrop(Locanda_Carta15_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta16_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 15;
            Locanda_Carta16_Panel.DoDragDrop(Locanda_Carta16_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta17_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 16;
            Locanda_Carta17_Panel.DoDragDrop(Locanda_Carta17_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta18_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 17;
            Locanda_Carta18_Panel.DoDragDrop(Locanda_Carta18_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta19_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 18;
            Locanda_Carta19_Panel.DoDragDrop(Locanda_Carta19_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta20_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            indiceCartaSelezionata = 19;
            Locanda_Carta20_Panel.DoDragDrop(Locanda_Carta20_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        //////////////////////////////ENTER

        private void Locanda_Slot1_Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Locanda_Slot2_Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Locanda_Slot3_Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Locanda_Slot4_Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Locanda_Slot5_Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Locanda_Slot6_Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Locanda_Slot7_Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Locanda_Slot8_Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }


        //////////////////////////////DROP

        private void Locanda_Slot1_Panel_DragDrop(object sender, DragEventArgs e)
        {
            ListaCarte.GetCarta(indiceCartaSelezionata).SetUtilizzabile(false);
            ListaCarte.GetCarta(indiceCartaSelezionata).IsSleeping = true;
            Locanda_Slot1_Panel.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
            Update();
        }

        private void Locanda_Slot2_Panel_DragDrop(object sender, DragEventArgs e)
        {
            ListaCarte.GetCarta(indiceCartaSelezionata).SetUtilizzabile(false);
            ListaCarte.GetCarta(indiceCartaSelezionata).IsSleeping = true;
            Locanda_Slot2_Panel.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
            Update();
        }

        private void Locanda_Slot3_Panel_DragDrop(object sender, DragEventArgs e)
        {
            ListaCarte.GetCarta(indiceCartaSelezionata).SetUtilizzabile(false);
            ListaCarte.GetCarta(indiceCartaSelezionata).IsSleeping = true;
            Locanda_Slot3_Panel.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
            Update();
        }

        private void Locanda_Slot4_Panel_DragDrop(object sender, DragEventArgs e)
        {
            ListaCarte.GetCarta(indiceCartaSelezionata).SetUtilizzabile(false);
            ListaCarte.GetCarta(indiceCartaSelezionata).IsSleeping = true;
            Locanda_Slot4_Panel.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
            Update();
        }

        private void Locanda_Slot5_Panel_DragDrop(object sender, DragEventArgs e)
        {
            ListaCarte.GetCarta(indiceCartaSelezionata).SetUtilizzabile(false);
            ListaCarte.GetCarta(indiceCartaSelezionata).IsSleeping = true;
            Locanda_Slot5_Panel.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
            Update();
        }

        private void Locanda_Slot6_Panel_DragDrop(object sender, DragEventArgs e)
        {
            ListaCarte.GetCarta(indiceCartaSelezionata).SetUtilizzabile(false);
            ListaCarte.GetCarta(indiceCartaSelezionata).IsSleeping = true;
            Locanda_Slot6_Panel.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
            Update();
        }

        private void Locanda_Slot7_Panel_DragDrop(object sender, DragEventArgs e)
        {
            ListaCarte.GetCarta(indiceCartaSelezionata).SetUtilizzabile(false);
            ListaCarte.GetCarta(indiceCartaSelezionata).IsSleeping = true;
            Locanda_Slot7_Panel.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
            Update();
        }

        private void Locanda_Slot8_Panel_DragDrop(object sender, DragEventArgs e)
        {
            ListaCarte.GetCarta(indiceCartaSelezionata).SetUtilizzabile(false);
            ListaCarte.GetCarta(indiceCartaSelezionata).IsSleeping = true;
            Locanda_Slot8_Panel.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
            Update();
        }
    }
}