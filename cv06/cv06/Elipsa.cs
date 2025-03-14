using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Elipsa : Objekt2D
    {
        private double poloosaA;
        private double poloosaB;

        public Elipsa(double a, double b)
        {
            poloosaA = a;
            poloosaB = b;
        }

        public override double SpoctiPlochu()
        {
            return poloosaA * poloosaB * Math.PI;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Elipsa - poloosa A:{poloosaA}, poloosa B:{poloosaB}");
        }
    }
}
