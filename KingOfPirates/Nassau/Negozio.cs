using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //Per le Bitmap

namespace KingOfPirates.Nassau
{
    class Negozio : Edificio
    {

        private int livelloNegozio; //salva il livello degli upgrade

        public Negozio(Bitmap immagine_) : base("Negozio", immagine_)
        {

        }

        //TODO: public void RiscattaTaglie(Player p){}
        //TODO: public void AcquistaBevandaDeterminazione(Player p){}
        //TODO: public void AcquistaRum(Player p){}
        //TODO: public void AcquistaAntiubriachezza(Player p){}
        //TODO: public void AcquistaAssiLegno(Player p){}
        //TODO: public void AcquistaCarta(Player p, Carta c){}

        public override void Upgrade()
        {

        }
    }
}
