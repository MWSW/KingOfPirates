using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingOfPirates.Missioni.ScontroCarte.Carte;
using KingOfPirates.Missioni.ScontroCarte.Carte.CarteEffetto;

namespace KingOfPirates.Missioni.ScontroCarte.Opponenti
{
    public abstract class ListaCarte
    {
       public static Carta GetCarta(int indice)
       {
            switch(indice)
            {
                case 0:
                    return new CartaBase("PunPun1", 4, Properties.Resources.pun_pun, 5, 6, 'f');
                    break;
                case 1:
                    return new CartaBase("PunPun2", 4, Properties.Resources.pun_pun1, 7, 2, 'g');
                    break;
                case 2:
                    return new CartaBase("PunPun3", 4, Properties.Resources.pun_pun2, 2, 2, 's');
                    break;
                case 3:
                    return new CartaBase("CoolPun", 4, Properties.Resources.pun_pun, 3, 1, 's');
                    break;
                case 4:
                    return new CartaBase("SaddyPun", 4, Properties.Resources.pun_pun2, 4, 2, 'g');
                    break;
                case 5:
                    return new CartaBase("Punpunya", 4, Properties.Resources.pun_pun1, 3, 5, 'f');
                    break;
                case 6:
                    return new CartaCura("Cura", 4, Properties.Resources.curaPozione, 4);
                    break;
                case 7:
                    return new CartaCuraEstesa("Cura+", 4, Properties.Resources.curaEstesa, 1, 3);
                    break;
                case 8:
                    return new CartaBuff("Pow", 4, Properties.Resources.BufferDrink, 1, 3);
                    break;

            }

            MessageBox.Show("Error - carta non trovata (lista carte)");
            return null;
       }
    }
}
