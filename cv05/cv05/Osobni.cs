using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Osobni : Auto
    {

        private int maxOsob;
        private int prepravovaneOsoby;

        public Osobni(int pocetOsob, double stavNadrze, TypPaliva mojePalivo) : base(stavNadrze, mojePalivo)
        {
            maxOsob = 5;
            velikostNadrze = 70;

            if (pocetOsob <= maxOsob && stavNadrze <= velikostNadrze)
            {
                prepravovaneOsoby = pocetOsob;
                palivo = mojePalivo;
            }
            else
                throw new Exception("Presahnut pocet osob nebo stav nadrze");
        }

        public override string ToString()
        {
            return String.Format($"Prepravovano osob:{prepravovaneOsoby}, Stav nadrze:{stavNadrze}, Typ paliva:{palivo}");
        }

    }
}
