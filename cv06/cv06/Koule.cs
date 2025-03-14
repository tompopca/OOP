using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Koule : Objekt3D
    {
        private double polomer;

        public Koule(double p)
        {
            polomer = p;
        }

        public override double SpoctiPovrch()
        {
            return 4 * Math.PI * polomer * polomer;
        }

        public override double SpoctiObjem()
        {
            return (4 * Math.PI * polomer * polomer * polomer) * 3;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Koule - polomer:{polomer}");
        }
    }
}
