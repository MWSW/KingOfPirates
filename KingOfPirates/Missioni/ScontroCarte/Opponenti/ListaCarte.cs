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

        private static Carta[] listaCarte = 
        { new CartaBase("PunPun1", 20, Properties.Resources.pun_pun, 5, 6, 'f'),
        new CartaBase("PunPun2", 20, Properties.Resources.pun_pun1, 7, 2, 'g'),
        new CartaBase("PunPun3", 20, Properties.Resources.pun_pun2, 2, 2, 's'),
        new CartaBase("CoolPun", 20, Properties.Resources.pun_pun, 3, 1, 's'),
        new CartaBase("SaddyPun", 20, Properties.Resources.pun_pun2, 4, 2, 'g'),
        new CartaBase("Punpunya", 20, Properties.Resources.pun_pun1, 3, 5, 'f'),
        new CartaBase("abc", 20, Properties.Resources.pun_pun1, 3, 5, 'f'),
        new CartaBase("acb", 20, Properties.Resources.pun_pun1, 3, 5, 'f'),
        new CartaBase("cab", 20, Properties.Resources.pun_pun1, 3, 5, 'f'),
        new CartaBase("cba", 20, Properties.Resources.pun_pun1, 3, 5, 'f'),
        new CartaBase("bac", 20, Properties.Resources.pun_pun1, 3, 5, 'f'),
        new CartaBase("bca", 20, Properties.Resources.pun_pun1, 3, 5, 'f'),
        new CartaBase("123", 20, Properties.Resources.pun_pun1, 3, 5, 'f'),
        new CartaBase("124", 20, Properties.Resources.pun_pun1, 3, 5, 'f'),
        new CartaBase("756", 20, Properties.Resources.pun_pun1, 3, 5, 'f'),
        new CartaCura("Cura", 5, Properties.Resources.curaPozione, 4),
        new CartaCuraEstesa("Cura+", 5, Properties.Resources.curaEstesa, 1, 3),
        new CartaBuff("Pow", 5, Properties.Resources.BufferDrink, 1, 3),
        new CartaDebuff("Fear", 5, Properties.Resources.depotenziamento, -1, 3),
        new CartaDannoContinuo("Bleeding", 5, Properties.Resources.dannoPerpetuo, 1, 3)};
       public static Carta GetCarta(int indice)
       {
            return listaCarte[indice]; //passaggio per riferimento
       }

       public static Carta GetCartaClone(int indice)
       {
            return listaCarte[indice].Clona();
       }
    }
}
