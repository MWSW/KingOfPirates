using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; //Per le Image
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.Navi.Opponenti;

namespace KingOfPirates.Missioni.Navi
{
    /// <summary>
    /// Nave rappresentante il giocatore con funzioni speciali.
    /// </summary>
    public class NaveGiocatore : Nave
    {
        /// <summary>
        /// Verifica che sia su terreno o meno.
        /// </summary>
        private bool StaNavigando { get; set; }
        /// <summary>
        /// Parte da 0, Aumenta più si scava
        /// </summary>
        public int Ubriachezza { get; set; }
        public int UbriachezzaMax { get; set; }
        /// <summary>
        /// Inizia al 75% della DeterminazioneMax
        /// </summary>
        public int Determinazione { get; set; }
        public int DeterminazioneMax { get; set; }
        /// <summary>
        /// Il giocatore ha degli oggetti speciali che vengono immagazzinati qui
        /// </summary>
        public Inventario Inventario { get; set; }

        /// <summary>
        /// Unico costruttore con tutti parametri.
        /// </summary>
        /// <param name="nome_">Assegna il nome alla nave.</param>
        /// <param name="immagine_">Assegna l'aspetto della nave per il FormMissione.</param>
        /// <param name="stats_">Statistiche per la nave.</param>
        /// <param name="loc_">Coordinate da usare nel FormMissione.</param>
        /// <param name="ubriachezzaMax">Indicatore per l'equipaggio.</param>
        /// <param name="determinazioneMax">Valore per le carte</param>

        public NaveGiocatore(string nome_, Image immagine_, Stats stats_, Loc2D loc_, int ubriachezzaMax, int determinazioneMax) : base(nome_, immagine_, stats_, loc_)
        {
            StaNavigando = false;
            UbriachezzaMax = ubriachezzaMax;
            Ubriachezza = 0;
            DeterminazioneMax = determinazioneMax;
            Determinazione = (int)(DeterminazioneMax * 0.75f); //parte da 3/4 del totale
            Inventario = new Inventario(5,5,5,5); //FIXME
        }

        public override void Attacca(Nave nave)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// La funzione fa muovere la nave data la missione in cui effetuare il movimento e la direzione in cui muoversi.
        /// </summary>
        /// <param name="missione">Per permettere il movimento all'interno della mappa della missione.</param>
        /// <param name="direzione">per specificare la direzione in cui effetuare il movimento.</param>

        public override void Movimento(Missione missione, Direzione direzione) //(Virtual) indica che può essere esteso dai figli
        {
            // Controlla se l'energia è finita
            if (Stats.Pa <= 0)
            {
                MessageBox.Show("Energia finita!");
                Stats.Pa = Stats.PaMax; //ripristino energia
                missione.Mappa.EnergiaNave_label.Text = "Punti azione: " + Stats.Pa + "/" + Stats.PaMax; //aggiorna energia_label
                return;
            }
            switch (direzione)
            {
                default:
                    break;
                case Direzione.SOPRA:
                    if (Gioco.Giocatore.Loc.Y - 1 < 0) return;// Controllo se è al limite della mappa e vieta il movimento
                    if (missione.Griglia_numerica.Mat[this.Loc.X, this.Loc.Y - 1] == 2) return;// Controlla se è vicino a una montagna e vieta il movimento

                    missione.Mappa.Griglia_pictureBox[this.Loc.X, this.Loc.Y].BackgroundImage = missione.Mappa.temp; //texture vecchia
                    this.Loc.Y--; //aggiorno la posizione
                    break;
                case Direzione.DESTRA:
                    if (Gioco.Giocatore.Loc.X + 1 > missione.Griglia_numerica.Mat.GetLength(0) - 1) return;
                    if (missione.Griglia_numerica.Mat[this.Loc.X + 1, this.Loc.Y] == 2) return;

                    missione.Mappa.Griglia_pictureBox[this.Loc.X, this.Loc.Y].BackgroundImage = missione.Mappa.temp; //texture vecchia
                    this.Loc.X++; //aggiorno la posizione
                    break;
                case Direzione.SINISTRA:
                    if (Gioco.Giocatore.Loc.X - 1 < 0) return;
                    if (missione.Griglia_numerica.Mat[this.Loc.X - 1, this.Loc.Y] == 2) return;

                    missione.Mappa.Griglia_pictureBox[this.Loc.X, this.Loc.Y].BackgroundImage = missione.Mappa.temp; //texture vecchia
                    this.Loc.X--; //aggiorno la posizione
                    break;
                case Direzione.SOTTO:
                    if (Gioco.Giocatore.Loc.Y + 1 > missione.Griglia_numerica.Mat.GetLength(1) - 1) return;
                    if (missione.Griglia_numerica.Mat[this.Loc.X, this.Loc.Y + 1] == 2) return;

                    missione.Mappa.Griglia_pictureBox[this.Loc.X, this.Loc.Y].BackgroundImage = missione.Mappa.temp; //texture vecchia
                    this.Loc.Y++; //aggiorno la posizione
                    break;
            }
            missione.Mappa.temp = missione.Mappa.Griglia_pictureBox[this.Loc.X, this.Loc.Y].BackgroundImage; //aggiorno temp
            //cambia immagine se è sopra una isola
            if (missione.Griglia_numerica.Mat[Loc.X, Loc.Y] == 1)
                missione.Mappa.Griglia_pictureBox[Loc.X, Loc.Y].BackgroundImage = Properties.Resources.omino;
            else
                missione.Mappa.Griglia_pictureBox[Loc.X, Loc.Y].BackgroundImage = Properties.Resources.nave_pirata;
            RemEnergia(1); //consumi energia
            missione.Mappa.EnergiaNave_label.Text = "Punti azione: " + Stats.Pa + "/" + Stats.PaMax; //aggiorna energia_label
        }

        public void Abborda(NaveNemico nave)
        {
            //
        }
        public void Scavare() 
        {
            //
        }

        public void RemEnergia(int enTolta)
        {
            Stats.Pa -= enTolta;
        }

        public void IncUbriachezza(int punti)
        {
            Ubriachezza += punti;

            if (Ubriachezza > UbriachezzaMax)
                Ubriachezza = UbriachezzaMax;
        }

        public void DecUbriachezza(int punti)
        {
            Ubriachezza -= punti;

            if (Ubriachezza < 0)
                Ubriachezza = 0;
        }

        public void IncDeterminazione(int punti)
        {
            Determinazione += punti;

            if (Determinazione > DeterminazioneMax)
                Determinazione = DeterminazioneMax;
        }

        public void DecDeterminazione(int punti)
        {
            Determinazione -= punti;

            if (Determinazione < 0)
                Determinazione = 0;
        }

        //TODO: public void UsaOggetto(Oggetto ob){}
    }
}
