using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //Per le Bitmap
using KingOfPirates.Missioni.Roba;
using KingOfPirates.GUI.MenuMissioni;

namespace KingOfPirates.Missioni.Navi
{
    public abstract class Nave
    {
        private string nome;
        private Image immagine;
        private bool isGameOver;

        public Stats Stats { get; set; }
        public Loc2D Loc { get; set; }

        protected Nave(String nome_, Image immagine_, Stats stats_,  Loc2D loc_)
        {
            nome = nome_;
            immagine = immagine_;
            Stats = stats_;
            Loc = loc_;

            isGameOver = false; //la nave parte in vita
        }

        /// <summary>
        /// La funzione fa muovere la nave data la missione in cui effetuare il movimento e la direzione in cui muoversi
        /// </summary>
        /// <param name="missione"></param>
        /// <param name="direzione"></param>

        public virtual void Movimento(Missione missione, Direzione direzione) //(Virtual) indica che può essere esteso dai figli
        {
            if (Stats.Pa <= 0) {
                MessageBox.Show("Energia finita!");
                Stats.Pa = Stats.PaMax; //ripristino energia
                missione.Mappa.EnergiaNave_label.Text = "Punti azione: " + Stats.Pa + "/" + Stats.PaMax; //aggiorna energia_label
                return;
            }
            switch (direzione)
            {
                case Direzione.SOPRA:
                    if (Gioco.Giocatore.Loc.Y - 1 < 0) return;
                    if (missione.Griglia_numerica.Mat[this.Loc.X, this.Loc.Y - 1] == 2) return;

                    missione.Mappa.Griglia_pictureBox[this.Loc.X, this.Loc.Y].BackgroundImage = missione.Mappa.temp; //texture vecchia
                    this.Loc.Y--; //aggiorno la posizione
                    missione.Mappa.temp =missione.Mappa.Griglia_pictureBox[this.Loc.X, this.Loc.Y].BackgroundImage; //aggiorno temp

                    //cambia immagine se è sopra una isola
                    if (missione.Griglia_numerica.Mat[Loc.X, Loc.Y] == 1)
                        missione.Mappa.Griglia_pictureBox[Loc.X, Loc.Y].BackgroundImage = Properties.Resources.omino;
                    else
                        missione.Mappa.Griglia_pictureBox[Loc.X, Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;

                    Gioco.Giocatore.RemEnergia(1); //consumi energia
                    missione.Mappa.EnergiaNave_label.Text = "Punti azione: " + Stats.Pa + "/" + Stats.PaMax; //aggiorna energia_label
                    break;
                case Direzione.DESTRA:
                    if (Gioco.Giocatore.Loc.X - 1 < 0) return;
                    if (missione.Griglia_numerica.Mat[this.Loc.X + 1, this.Loc.Y] == 2) return;

                    missione.Mappa.Griglia_pictureBox[this.Loc.X, this.Loc.Y].BackgroundImage = missione.Mappa.temp; //texture vecchia
                    this.Loc.X++; //aggiorno la posizione
                    missione.Mappa.temp = missione.Mappa.Griglia_pictureBox[this.Loc.X, this.Loc.Y].BackgroundImage; //aggiorno temp

                    //cambia immagine se è sopra una isola
                    if (missione.Griglia_numerica.Mat[Loc.X, Loc.Y] == 1)
                        missione.Mappa.Griglia_pictureBox[Loc.X, Loc.Y].BackgroundImage = Properties.Resources.omino;
                    else
                        missione.Mappa.Griglia_pictureBox[Loc.X, Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;

                    Gioco.Giocatore.RemEnergia(1); //consumi energia
                    missione.Mappa.EnergiaNave_label.Text = "Punti azione: " + Stats.Pa + "/" + Stats.PaMax; //aggiorna energia_label
                    break;
                case Direzione.SINISTRA:
                    if (Gioco.Giocatore.Loc.X + 1 < 0) return;
                    if (missione.Griglia_numerica.Mat[this.Loc.X - 1, this.Loc.Y] == 2) return;

                    missione.Mappa.Griglia_pictureBox[this.Loc.X, this.Loc.Y].BackgroundImage = missione.Mappa.temp; //texture vecchia
                    this.Loc.X--; //aggiorno la posizione
                    missione.Mappa.temp = missione.Mappa.Griglia_pictureBox[this.Loc.X, this.Loc.Y].BackgroundImage; //aggiorno temp

                    //cambia immagine se è sopra una isola
                    if (missione.Griglia_numerica.Mat[Loc.X, Loc.Y] == 1)
                        missione.Mappa.Griglia_pictureBox[Loc.X, Loc.Y].BackgroundImage = Properties.Resources.omino;
                    else
                        missione.Mappa.Griglia_pictureBox[Loc.X, Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;

                    Gioco.Giocatore.RemEnergia(1); //consumi energia
                    missione.Mappa.EnergiaNave_label.Text = "Punti azione: " + Stats.Pa + "/" + Stats.PaMax; //aggiorna energia_label
                    break;
                case Direzione.SOTTO:
                    if (Gioco.Giocatore.Loc.Y + 1 < 0) return;
                    if (missione.Griglia_numerica.Mat[this.Loc.X, this.Loc.Y + 1] == 2) return;

                    missione.Mappa.Griglia_pictureBox[this.Loc.X, this.Loc.Y].BackgroundImage = missione.Mappa.temp; //texture vecchia
                    this.Loc.Y++; //aggiorno la posizione
                    missione.Mappa.temp = missione.Mappa.Griglia_pictureBox[this.Loc.X, this.Loc.Y].BackgroundImage; //aggiorno temp

                    //cambia immagine se è sopra una isola
                    if (missione.Griglia_numerica.Mat[Loc.X, Loc.Y] == 1)
                        missione.Mappa.Griglia_pictureBox[Loc.X, Loc.Y].BackgroundImage = Properties.Resources.omino;
                    else
                        missione.Mappa.Griglia_pictureBox[Loc.X, Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;

                    RemEnergia(1); //consumi energia
                    missione.Mappa.EnergiaNave_label.Text = "Punti azione: " + Stats.Pa + "/" + Stats.PaMax; //aggiorna energia_label
                    break;
                default:
                    break;
            }
        }

        public virtual void Movimento(Nave nave, Loc2D spostamento) //(Virtual) indica che può essere esteso dai figli
        {
            //
        }

        public virtual void Attacca(Nave nave) 
        {
            //
        }

        public abstract void RemEnergia(int enTolta);
        public abstract void IncUbriachezza(int punti);
        public abstract void DecUbriachezza(int punti);
        public abstract void IncDeterminazione(int punti);
        public abstract void DecDeterminazione(int punti);
        public abstract void IncPuntiVita(int punti);
        public abstract void DecPuntiVita(int punti);
    }
}
