using cv05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Osobni osobak = new Osobni(2, 50, Auto.TypPaliva.Benzin);
            Nakladni nakladak = new Nakladni(15, 110, Auto.TypPaliva.Nafta);

            osobak.nastavRadio(true);
            osobak.nastavPredvolbu(3, 142);
            osobak.nastavPredvolbu(4, 55.8);
            osobak.preladNaPredvolbu(3);
            osobak.vypisRadio();
            osobak.preladNaPredvolbu(4);
            osobak.vypisRadio();

            Console.WriteLine();
            Console.WriteLine(osobak);
            Console.WriteLine(nakladak);
            Console.WriteLine();


            osobak.nastavRadio(false);
            osobak.vypisRadio();
            Console.WriteLine();
            osobak.natankuj(Auto.TypPaliva.Benzin, 2.5);
            Console.WriteLine(osobak);
            Console.ReadLine();
        }
    }
}
