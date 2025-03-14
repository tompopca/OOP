using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Kruh : Objekt2D
    {
        private double polomer;

        public Kruh(double p)
        {
            polomer = p;
        }

        public override double SpoctiPlochu()
        {
            return Math.PI * polomer * polomer;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Kruh - polomer:{polomer}");
        }
    }
}
