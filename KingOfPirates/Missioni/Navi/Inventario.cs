using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni.Navi.Opponenti
{
    public class Inventario
    {
        public int BevandaDeterminazione { get; set; }
        public int Rum { get; set; }
        public int AntiUbriachezza { get; set; }
        public int AssiLegno { get; set; }

        public Inventario()
        {
            BevandaDeterminazione = 0;
            Rum = 0;
            AntiUbriachezza = 0;
            AssiLegno = 0;
        }

        public void IncBevandaDeterminazione()
        {
            BevandaDeterminazione ++;
        }

        public void IncRum()
        {
            Rum ++;
        }

        public void IncAntiUbriachezza()
        {
            AntiUbriachezza ++;
        }

        public void IncAssiLegno()
        {
            AssiLegno ++;
        }

        public void DecBevandaDeterminazione()
        {
            BevandaDeterminazione --;
        }

        public void DecRum()
        {
            Rum --;
        }

        public void DecAntiUbriachezza()
        {
            AntiUbriachezza --;
        }

        public void DecAssiLegno()
        {
            AssiLegno --;
        }
    }
}
