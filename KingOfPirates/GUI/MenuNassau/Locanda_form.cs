using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates.Nassau;
using KingOfPirates.Cartina;

namespace KingOfPirates.GUI.MenuNassau
{
    public partial class Locanda_form : Form
    {
        Locanda locanda = new Locanda();
        GestioneDominio gestoreDominio;

        public Locanda_form(GestioneDominio gestoreDominio)
        {
            this.gestoreDominio = gestoreDominio;
            InitializeComponent();

            LoadData();
        }

        private void Locanda_Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void LoadData()
        {
            //Locanda_Carta1_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta2_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta3_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta4_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta5_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta6_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta7_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta8_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta9_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta10_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta11_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta12_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta13_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta14_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta15_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta16_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta17_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta18_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta19_Panel.BackgroundImage = mazzo.getCarta().getImage();
            //Locanda_Carta20_Panel.BackgroundImage = mazzo.getCarta().getImage();

            //Locanda_Det1_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det2_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det3_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det4_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det5_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det6_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det7_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det8_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det9_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det10_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det11_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det12_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det13_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det14_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det15_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det16_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det17_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det18_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det19_Label.Text = mazzo.getCarta().getDeterminazione();
            //Locanda_Det20_Label.Text = mazzo.getCarta().getDeterminazione();


        }

        //////////////////////////////DRAG

        private void Locanda_Carta1_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta1_Panel.DoDragDrop(Locanda_Carta1_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta2_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta2_Panel.DoDragDrop(Locanda_Carta2_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta3_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta3_Panel.DoDragDrop(Locanda_Carta3_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta4_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta4_Panel.DoDragDrop(Locanda_Carta4_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta5_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta5_Panel.DoDragDrop(Locanda_Carta5_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta6_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta6_Panel.DoDragDrop(Locanda_Carta6_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta7_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta7_Panel.DoDragDrop(Locanda_Carta7_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta8_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta8_Panel.DoDragDrop(Locanda_Carta8_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta9_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta9_Panel.DoDragDrop(Locanda_Carta9_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta10_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta10_Panel.DoDragDrop(Locanda_Carta10_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta11_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta11_Panel.DoDragDrop(Locanda_Carta11_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta12_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta12_Panel.DoDragDrop(Locanda_Carta12_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta13_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta13_Panel.DoDragDrop(Locanda_Carta13_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta14_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta14_Panel.DoDragDrop(Locanda_Carta14_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta15_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta15_Panel.DoDragDrop(Locanda_Carta15_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta16_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta16_Panel.DoDragDrop(Locanda_Carta16_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta17_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta17_Panel.DoDragDrop(Locanda_Carta17_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta18_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta18_Panel.DoDragDrop(Locanda_Carta18_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta19_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta19_Panel.DoDragDrop(Locanda_Carta19_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void Locanda_Carta20_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Locanda_Carta20_Panel.DoDragDrop(Locanda_Carta20_Panel.BackgroundImage, DragDropEffects.Copy | DragDropEffects.Move);
        }

        //////////////////////////////DROP

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
    }
}
