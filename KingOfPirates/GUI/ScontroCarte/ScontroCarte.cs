using KingOfPirates.Missioni.ScontroCarte.Carte;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingOfPirates.GUI.ScontroCarte
{
    public partial class ScontroCarte : Form
    {

        //due sfindanti dello scontro a carte
        Player_carte player;
        //Nemico_carte nemico;

        

        public ScontroCarte()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            //Assegnare delle carte al giocatore
            MessageBox.Show("Hello my friends!");

            //Inizializzo gli oggetti

            Carta[] carte = {ListaCarte.GetCarta(0),
                 ListaCarte.GetCarta(1), ListaCarte.GetCarta(1), ListaCarte.GetCarta(2), ListaCarte.GetCarta(0)};

            player = new Player_carte(10, new Mazzo(carte));

            //Devo differenziare se poi la carta è normale oppure effetto

            //Prima mano
            player.CarteInMano[0].Visualizza(img_carta1, nomeCarta1, det1, att1, def1, elem1);
            player.CarteInMano[1].Visualizza(img_carta2, nomeCarta2, det2, att2, def2, elem2);
            player.CarteInMano[2].Visualizza(img_carta3, nomeCarta3, det3, att3, def3, elem3);
            player.CarteInMano[3].Visualizza(img_carta4, nomeCarta4, det4, att4, def4, elem4);

        }
    }
}
