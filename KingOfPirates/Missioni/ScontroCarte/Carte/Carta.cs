using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //Per le Bitmap
using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using System.Windows.Forms;

namespace KingOfPirates.Missioni.ScontroCarte.Carte
{
    abstract class Carta
    {
        protected string nome;
        protected int determinazione;
        protected bool utilizzabile; //Non so se va in conflitto con mazzo
        protected Bitmap immagine;

        private int indice;

        private string tipo;

        protected Carta(string nome_, int determinazione_, Bitmap immagine_, string tipo_)
        {
            nome = nome_;
            determinazione = determinazione_;
            immagine = immagine_;

            tipo = tipo_;
        }

        public void Visualizza(PictureBox img_carta, Label nomeCarta, Label det)
        {
            img_carta.Image = Properties.Resources.cartaVuota;
            img_carta.Show();
            nomeCarta.Show();
            det.Show();

            img_carta.BackgroundImage = immagine;
            nomeCarta.Text = nome;
            det.Text = determinazione.ToString();
        }

        public void Nascondi(PictureBox img_carta, Label nomeCarta, Label det)
        {
            img_carta.BackgroundImage = null;
            img_carta.Hide();
            nomeCarta.Hide();
            det.Hide();
        }

        public virtual void Nascondi(PictureBox img_carta, Label nomeCarta, Label det, Label atk_label, Label def_label, PictureBox elem)
        {
            Nascondi(img_carta, nomeCarta, det);
        }

        public virtual void Visualizza(PictureBox img_carta, Label nomeCarta, Label det, Label atk_label, Label def_label, PictureBox elem)
        {
            Visualizza(img_carta, nomeCarta, det);
        }

        public abstract void UsaCarta(Giocatore_carte_base utilizzatore); //FIXME

        public void AddDeterminazione(int val)
        {
           determinazione += val;
        } 
        public void DimDeterminazione(int val)
        {
           determinazione -= val;
        } 

        public bool GetUtilizzabile()
        {
            return utilizzabile;
        }

        public void SetUtilizzabile(bool b)
        {
            utilizzabile = b;
        }

        public Bitmap Immagine { get => immagine; }
        public string Nome { get => nome; }
        public int Determinazione { get => determinazione; }
        public int Indice { get => indice; set => indice = value; }

        public string Tipo { get => tipo; }
    }
}
