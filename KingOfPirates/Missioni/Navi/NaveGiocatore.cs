﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //Per le Bitmap
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.Navi.Opponenti;

namespace KingOfPirates.Missioni.Navi
{
    public class NaveGiocatore : Nave
    {

        private bool staNavigando; //Verifica che sia su terreno o meno
        private int ubriachezza;
        public int Energia { get; set; }

        private Inventario inventario;

        //TO-FIX: Per ora Stats e Loc2D sono a zero

        public NaveGiocatore(String nome_, Bitmap immagine_) : base(nome_, immagine_, new Stats(), new Loc2D())
        {
            inventario = new Inventario();
        }
        
        public Inventario Inventario { get => inventario; set => inventario = value; }

        public override void Movimento(Loc2D spostamento)
        {
            base.Movimento(spostamento);
        }

        public void Abborda(NaveNemico nave)
        {

        }
        public void Scavare() 
        {

        }

        public void RemEnergia(int enTolta)
        {
            Energia += enTolta;
        }

        //TODO: public void UsaOggetto(Oggetto o){}
    }
}
