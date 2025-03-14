using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Obdelnik : Objekt2D
    {
        private double stranaA;
        private double stranaB;

        public Obdelnik(double a, double b)
        {
            stranaA = a;
            stranaB = b;
        }

        public override double SpoctiPlochu()
        {
            return stranaA * stranaB;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Obdelnik - strana A:{stranaA}, strana B:{stranaB}");
        }
    }
}
