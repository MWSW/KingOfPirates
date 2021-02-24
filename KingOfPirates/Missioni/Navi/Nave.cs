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
        internal Missione Missione { get; set; }
        private string nome;
        private Image immagine;
        private bool isGameOver;

        public Stats Stats { get; set; }
        public Loc2D Loc { get; set; }
        public int Energia { get; set; }
        public int EnergiaMax { get; set; }

        protected Nave(Missione missione, String nome_, Image immagine_, Stats stats_,  Loc2D loc_)
        {
            Missione = missione;
            nome = nome_;
            immagine = immagine_;
            Stats = stats_;
            Loc = loc_;

            isGameOver = false; //la nave parte in vita
        }

        public virtual void Movimento(Nave nave, Direzione direzione) //(Virtual) indica che può essere esteso dai figli
        {
            if (Gioco.Giocatore.Loc.Y - 1 < 0) return;
            if (nave.Loc.Y - 1 <= 0)
            {
                MessageBox.Show("Energia finita!");
                Gioco.Giocatore.Energia = Gioco.Giocatore.EnergiaMax; //ripristino energia
                Missione.Mappa.EnergiaNave_label.Text = "Punti azione: " + Gioco.Giocatore.Energia + "/" + Gioco.Giocatore.EnergiaMax; //aggiorna energia_label
                return;
            }
            switch (direzione)
            {
                case Direzione.SOPRA:
                    if (Missione.Griglia_numerica.Mat[nave.Loc.X, nave.Loc.Y - 1] == 2) return;

                    Missione.Mappa.Griglia_pictureBox[nave.Loc.X, nave.Loc.Y].BackgroundImage = Missione.Mappa.temp; //texture vecchia
                    nave.Loc.Y--; //aggiorno la posizione
                    Missione.Mappa.temp = Missione.Mappa.Griglia_pictureBox[nave.Loc.X, nave.Loc.Y].BackgroundImage; //aggiorno temp

                    //cambia immagine se è sopra una isola
                    if (Missione.Griglia_numerica.Mat[nave.Loc.X, nave.Loc.Y + 1] == 1)
                        Missione.Mappa.Griglia_pictureBox[nave.Loc.X, nave.Loc.Y].BackgroundImage = Properties.Resources.omino;
                    else
                        Missione.Mappa.Griglia_pictureBox[nave.Loc.X, nave.Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;

                    Gioco.Giocatore.RemEnergia(1); //consumi energia
                    Missione.Mappa.EnergiaNave_label.Text = "Punti azione: " + nave.Energia + "/" + nave.EnergiaMax; //aggiorna energia_label
                    break;
                case Direzione.DESTRA:
                    break;
                case Direzione.SINISTRA:
                    break;
                case Direzione.SOTTO:
                    if (Missione.Griglia_numerica.Mat[nave.Loc.X, nave.Loc.Y + 1] == 2) return;

                    Missione.Mappa.Griglia_pictureBox[nave.Loc.X, nave.Loc.Y].BackgroundImage = Missione.Mappa.temp; //texture vecchia
                    nave.Loc.Y++; //aggiorno la posizione
                    Missione.Mappa.temp = Missione.Mappa.Griglia_pictureBox[nave.Loc.X, nave.Loc.Y].BackgroundImage; //aggiorno temp

                    //cambia immagine se è sopra una isola
                    if (Missione.Griglia_numerica.Mat[nave.Loc.X, nave.Loc.Y] == 1)
                        Missione.Mappa.Griglia_pictureBox[nave.Loc.X, nave.Loc.Y].BackgroundImage = Properties.Resources.omino;
                    else
                        Missione.Mappa.Griglia_pictureBox[nave.Loc.X, nave.Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;

                    Gioco.Giocatore.RemEnergia(1); //consumi energia
                    Missione.Mappa.EnergiaNave_label.Text = "Punti azione: " + nave.Energia + "/" + nave.EnergiaMax; //aggiorna energia_label
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
