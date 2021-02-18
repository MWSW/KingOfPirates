using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni.Navi.Opponenti
{
    public class Inventario
    {
        private int bevandaDeterminazione;
        private int rum;
        private int antiUbriachezza;
        private int assiLegno;

        public int BevandaDeterminazione { get => bevandaDeterminazione; set => bevandaDeterminazione = value; }
        public int Rum { get => rum; set => rum = value; }
        public int AntiUbriachezza { get => antiUbriachezza; set => antiUbriachezza = value; }
        public int AssiLegno { get => assiLegno; set => assiLegno = value; }

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
