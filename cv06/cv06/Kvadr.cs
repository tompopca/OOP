using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Kvadr : Objekt3D
    {
        private double stranaA;
        private double stranaB;
        private double stranaC;

        public Kvadr(double a, double b, double c)
        {
            stranaA = a;
            stranaB = b;
            stranaC = c;
        }

        public override double SpoctiPovrch()
        {
            return 2 * (stranaA * stranaB + stranaB * stranaC + stranaA * stranaC);
        }

        public override double SpoctiObjem()
        {
            return stranaA * stranaB * stranaC;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Kvadr - strana A:{stranaA}, strana B:{stranaB}, strana C:{stranaC}");
        }
    }
}
