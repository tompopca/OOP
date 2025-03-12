﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Auto
    {

        public enum TypPaliva { Benzin, Nafta }
        protected double velikostNadrze;
        protected double stavNadrze;
        protected TypPaliva palivo;
        private Autoradio radio = new Autoradio();
      

        public Auto(double nadrz, TypPaliva mojePalivo)
        {
            stavNadrze = nadrz;
            palivo = mojePalivo;

        }

        public double velikost
        {
            get { return velikostNadrze; }
            set { velikostNadrze = value; }
        }

        public double stav
        {
            get { return stavNadrze; }
            set { stavNadrze = value; }
        }

        public TypPaliva palivoTyp
        {
            get { return palivo; }
            set { palivo = value; }
        }

        public void natankuj(TypPaliva palivo, double mnozstvi)
        {
            if ((stavNadrze + mnozstvi) <= velikostNadrze && this.palivo == palivo)
            {
                stavNadrze += mnozstvi;
            }
            else
            {
                throw new Exception("Spatne zadane mnozstvi nebo palivo.");
            }
        }

        public void nastavRadio(bool x)
        {
            radio.zapnoutRadio(x);
        }

        public void nastavPredvolbu(int cislo, double kmitocet)
        {
            radio.nastavPredvolbu(cislo, kmitocet);
        }

        public void preladNaPredvolbu(int cislo)
        {
            radio.preladNaPredvolbu(cislo);
        }
        public void vypisRadio()
        {
            Console.WriteLine(radio);
        }

    }
}
