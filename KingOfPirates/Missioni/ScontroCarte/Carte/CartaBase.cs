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
    class CartaBase : Carta
    {
        private int atk;
        private int def;
        private char elemento;

        private int buff;

        public CartaBase(string nome_, int determinazione_, Bitmap immagine_, int atk_, int def_, char elemento_)
            :base(nome_, determinazione_, immagine_, "attacco")
        {
            buff = 0;

            atk = atk_;
            def = def_;
            elemento = elemento_;
        }

        public override void  Visualizza(PictureBox img_carta, Label nomeCarta, Label det, Label atk_label, Label def_label, PictureBox elem)
        {
            base.Visualizza(img_carta, nomeCarta, det);

            atk_label.Show();
            def_label.Show();
            elem.Show();

            atk_label.Text = "A:" + atk.ToString();
            def_label.Text = "D:" + def.ToString();

            switch (elemento)
            {
                case 'f':
                    elem.Image = Properties.Resources.fuoco;
                    break;
                case 'g':
                    elem.Image = Properties.Resources.ghiaccio;
                    break;
                case 's':
                    elem.Image = Properties.Resources.Sasso;
                    break;
                default:
                    //errore
                    break;
            }
        }

        public override void Nascondi(PictureBox img_carta, Label nomeCarta, Label det, Label atk_label, Label def_label, PictureBox elem)
        {
            base.Nascondi(img_carta, nomeCarta, det);
            atk_label.Hide();
            def_label.Hide();
            elem.Hide();
        }

        public override void UsaCarta(Giocatore_carte_base g)
        {
            base.UsaCarta(g);
        }

        public override Carta Clona()
        {
            return new CartaBase(nome, determinazione, immagine, atk, def, elemento);
        }

        public int Atk { get => atk + buff; }
        public int Def { get => def + buff; }
        public char Elemento { get => elemento; }
        public void SetBuff(int buff_)
        {
            buff = buff_;
        }
    }
}
