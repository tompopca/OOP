using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Jehlan : Objekt3D
    {
        private double stranaA;
        private double stranaB;
        private double vyska;

        public Jehlan(double a, double b, double v)
        {
            stranaA = a;
            stranaB = b;
            vyska = v;
        }

        public override double SpoctiPovrch()
        {
            return stranaA * vyska * 2;
        }

        public override double SpoctiObjem()
        {
            return (stranaA * stranaA * vyska) / 3;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Jehlan - strana A:{stranaA}, strana B:{stranaB}, vyska:{vyska}");
        }
    }
}
