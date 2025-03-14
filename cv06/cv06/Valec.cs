using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Valec : Objekt3D
    {
        private double polomer;
        private double vyska;

        public Valec(double polomer, double vyska)
        {
            this.polomer = polomer;
            this.vyska = vyska;
        }

        public override double SpoctiPovrch()
        {
            return 2 * Math.PI * polomer * (polomer + vyska);
        }

        public override double SpoctiObjem()
        {
            return Math.PI * polomer * polomer * vyska;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Valec - polomer:{polomer}, vyska:{vyska}");
        }
    }
}
