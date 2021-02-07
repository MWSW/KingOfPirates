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

        //TO-DO: public void RiscattaTaglie(Player p){}
        //TO-DO: public void AcquistaBevandaDeterminazione(Player p){}
        //TO-DO: public void AcquistaRum(Player p){}
        //TO-DO: public void AcquistaAntiubriachezza(Player p){}
        //TO-DO: public void AcquistaAssiLegno(Player p){}
        //TO-DO: public void AcquistaCarta(Player p, Carta c){}

        public override void Upgrade()
        {

        }
    }
}
