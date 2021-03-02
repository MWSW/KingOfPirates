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
    /// <summary>
    /// Contiene tutti i metodi di base per tutte le navi.
    /// </summary>
    public abstract class Nave
    {
        private string nome;
        protected Image immagine;
        private bool isGameOver;

        public Stats Stats { get; set; }
        public Loc2D Loc { get; set; }

        /// <summary>
        /// Costruttore con tutti i parametri necessari.
        /// </summary>
        /// <param name="nome_">Assegna il nome alla nave.</param>
        /// <param name="immagine_">Assegna l'aspetto della nave per il FormMissione.</param>
        /// <param name="stats_">Statistiche per la nave.</param>
        /// <param name="loc_">Coordinate da usare nel FormMissione.</param>
        protected Nave(String nome_, Image immagine_, Stats stats_, Loc2D loc_)
        {
            nome = nome_;
            immagine = immagine_;
            Stats = stats_;
            Loc = loc_;

            isGameOver = false; //la nave parte in vita
        }

        public void IncPuntiVita(int punti)
        {
            Stats.Hp += punti;

            if (Stats.Hp > Stats.HpMax)
                Stats.Hp = Stats.HpMax;
        }

        public void DecPuntiVita(int punti)
        {
            Stats.Hp -= punti;

            if (Stats.Hp < 0)
                Stats.Hp = 0;
        }

        /// <summary>
        /// Attacca la neva specificata con danno random.
        /// </summary>
        /// <param name="nave">Nave da attaccare</param>
        public abstract bool Attacca(Missione missione, Nave nave);

        /// <summary>
        /// La funzione fa muovere la nave data la missione in cui effetuare il movimento e la direzione in cui muoversi.
        /// </summary>
        /// <param name="missione">Per permettere il movimento all'interno della mappa della missione.</param>
        /// <param name="direzione">per specificare la direzione in cui effetuare il movimento.</param>
        public abstract void Movimento(Missione missione, Direzione direzione);

        public Image Immagine { get => immagine; set => immagine = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
