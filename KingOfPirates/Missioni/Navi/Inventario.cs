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

        public Inventario(int bevandaDeterminazione, int rum, int antiUbriachezza, int assiLegno)
        {
            BevandaDeterminazione = bevandaDeterminazione;
            Rum = rum;
            AntiUbriachezza = antiUbriachezza;
            AssiLegno = assiLegno;
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

            if (BevandaDeterminazione < 0)
                BevandaDeterminazione = 0;
        }

        public void DecRum()
        {
            Rum --;

            if (Rum < 0)
                Rum = 0;
        }

        public void DecAntiUbriachezza()
        {
            AntiUbriachezza --;

            if (AntiUbriachezza < 0)
                AntiUbriachezza = 0;
        }

        public void DecAssiLegno()
        {
            AssiLegno --;

            if (AssiLegno < 0)
                AssiLegno = 0;
        }
    }
}
