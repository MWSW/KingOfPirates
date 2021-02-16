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
        Nemico_carte nemico;

        int cartaSelezionata;

        //Componenti grafiche
        PictureBox[] img_carta;
        Label[] nomeCarta;
        Label[] det;
        Label[] att;
        Label[] def;
        PictureBox[] elem;

        

        public ScontroCarte()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            cartaSelezionata = -1;

            //Componenti grafiche
            img_carta = new PictureBox[4];
            img_carta[0] = img_carta1;
            img_carta[1] = img_carta2;
            img_carta[2] = img_carta3;
            img_carta[3] = img_carta4;

            nomeCarta = new Label[4];
            nomeCarta[0] = nomeCarta1;
            nomeCarta[1] = nomeCarta2;
            nomeCarta[2] = nomeCarta3;
            nomeCarta[3] = nomeCarta4;

            det = new Label[4];
            det[0] = det1;
            det[1] = det2;
            det[2] = det3;
            det[3] = det4;

            att = new Label[4];
            att[0] = att1;
            att[1] = att2;
            att[2] = att3;
            att[3] = att4;

            def = new Label[4];
            def[0] = def1;
            def[1] = def2;
            def[2] = def3;
            def[3] = def4;

            elem = new PictureBox[4];
            elem[0] = elem1;
            elem[1] = elem2;
            elem[2] = elem3;
            elem[3] = elem4;


            //Inizializzo gli oggetti

            Carta[] carte = {ListaCarte.GetCarta(0),
                 ListaCarte.GetCarta(1), ListaCarte.GetCarta(1), ListaCarte.GetCarta(2), ListaCarte.GetCarta(0)};

            player = new Player_carte(10, new Mazzo(carte));
            nemico = new Nemico_carte(10, null, carte); //FIX-ME

            //Devo differenziare se poi la carta è normale oppure effetto

            //Prima mano
            for(int i = 0; i < player.CarteInMano.Length; i++)
                 player.CarteInMano[i].Visualizza(img_carta[i], nomeCarta[i], det[i], att[i], def[i], elem[i]);
            

        }

        private void img_carta1_Click(object sender, EventArgs e)
        {
            if (cartaSelezionata == -1) //Se nessuna carta è stata selezionata puoi interagire
            {
                player.CarteInMano[0].Nascondi(img_carta1, nomeCarta1, det1, att1, def1, elem1);
                cartaSelezionata = 0;

                //Mostra carta selezionata
                player.CarteInMano[0].Visualizza(img_carta0, nomeCarta0, det0, att0, def0, elem0);

                att0.BackColor = Color.LightBlue;
                elem0.BackColor = Color.LightBlue;

                det0.BackColor = Color.LightGoldenrodYellow;

                //Mostra bottone attacco e nascondi
                bt_attacco.Show();
                bt_nascondi.Show();
            }
        }

        private void img_carta2_Click(object sender, EventArgs e)
        {
            if (cartaSelezionata == -1) //Se nessuna carta è stata selezionata puoi interagire
            {
                player.CarteInMano[1].Nascondi(img_carta2, nomeCarta2, det2, att2, def2, elem2);
                cartaSelezionata = 1;

                //Mostra carta selezionata
                player.CarteInMano[1].Visualizza(img_carta0, nomeCarta0, det0, att0, def0, elem0);

                att0.BackColor = Color.LightBlue;
                elem0.BackColor = Color.LightBlue;

                det0.BackColor = Color.LightGoldenrodYellow;

                //Mostra bottone attacco e nascondi
                bt_attacco.Show();
                bt_nascondi.Show();
            }
        }

        private void img_carta3_Click(object sender, EventArgs e)
        {
            if (cartaSelezionata == -1) //Se nessuna carta è stata selezionata puoi interagire
            {
                player.CarteInMano[2].Nascondi(img_carta3, nomeCarta3, det3, att3, def3, elem3);
                cartaSelezionata = 2;

                //Mostra carta selezionata
                player.CarteInMano[2].Visualizza(img_carta0, nomeCarta0, det0, att0, def0, elem0);

                att0.BackColor = Color.LightBlue;
                elem0.BackColor = Color.LightBlue;

                det0.BackColor = Color.LightGoldenrodYellow;

                //Mostra bottone attacco e nascondi
                bt_attacco.Show();
                bt_nascondi.Show();
            }
        }

        private void img_carta4_Click(object sender, EventArgs e)
        {
            if (cartaSelezionata == -1) //Se nessuna carta è stata selezionata puoi interagire
            {
                player.CarteInMano[3].Nascondi(img_carta4, nomeCarta4, det4, att4, def4, elem4);
                cartaSelezionata = 3;

                //Mostra carta selezionata
                player.CarteInMano[3].Visualizza(img_carta0, nomeCarta0, det0, att0, def0, elem0);

                att0.BackColor = Color.LightBlue;
                elem0.BackColor = Color.LightBlue;

                det0.BackColor = Color.LightGoldenrodYellow;

                //Mostra bottone attacco e nascondi
                bt_attacco.Show();
                bt_nascondi.Show();
            }
        }

        private void bt_attacco_Click(object sender, EventArgs e)
        {
            bt_attacco.Hide();
            bt_nascondi.Hide();

            bt_successivo.Show();

            //Il nemico sceglie una carta
            CartaBase cartaNemico = (CartaBase)(nemico.UsaCarta());
            cartaNemico.Visualizza(img_cartaA, nomeCartaA, detA, attA, defA, elemA);

            detA.BackColor = Color.LightGoldenrodYellow;

            defA.BackColor = Color.LightBlue;

            CartaBase cartaTua = (CartaBase)(player.CarteInMano[cartaSelezionata]);

            //Controlla gli elementi

            //fuoco, sasso, ghiaccio
            //fuoco - sasso (fuoco)
            //ghiaccio - sasso (sasso)
            //fuoco - ghiaccio (ghiaccio)

            bool vittoria = cartaTua.Elemento == 'f' && cartaNemico.Elemento == 's' ||
                              cartaTua.Elemento == 's' && cartaNemico.Elemento == 'g' ||
                              cartaTua.Elemento == 'g' && cartaNemico.Elemento == 'f';

            float defPerc = 1.0f;
            float attPerc = 1.0f;
            if(vittoria) //vittoria elementale
            {
                attPerc = 1.3f;
                elem0.BackColor = Color.LightGreen;
                elemA.BackColor = Color.LightCoral;
            }
            else if(cartaTua.Elemento != cartaNemico.Elemento) //parità
            {
                elem0.BackColor = Color.LightSteelBlue;
                elemA.BackColor = Color.LightSteelBlue;
            }
            else //sconfitta elementale
            {
                defPerc = 1.3f;
                elem0.BackColor = Color.LightCoral;
                elemA.BackColor = Color.LightGreen;
            }

            //Per ora la determinazione non conta
            int dmg = (int)((cartaTua.Atk*attPerc) - (cartaNemico.Def * defPerc));

            if (dmg < 0)
                dmg = 0;

            nemico.LessHp(dmg);

            //Output vita

            vita_avversario.Text = "HP: " + nemico.CurHp + "/" + nemico.MaxHp;
            vita_avversario.ForeColor = Color.Red;

           // MessageBox.Show(dmg.ToString());
           // MessageBox.Show(nemico.CurHp.ToString());

        }

        private void bt_nascondi_Click(object sender, EventArgs e)
        {
            //rimetti carta in mano
            player.CarteInMano[cartaSelezionata]
                .Visualizza(img_carta[cartaSelezionata], nomeCarta[cartaSelezionata], det[cartaSelezionata],
                att[cartaSelezionata], def[cartaSelezionata], elem[cartaSelezionata]);

            //rimuovi dalla selezione
            player.CarteInMano[cartaSelezionata].Nascondi(img_carta0, nomeCarta0, det0, att0, def0, elem0);

            img_carta0.Show();
            img_carta0.Image = Properties.Resources.SpazioVuoto;
            

            bt_attacco.Hide();
            bt_nascondi.Hide();

            cartaSelezionata = -1;
        }
    }
}
