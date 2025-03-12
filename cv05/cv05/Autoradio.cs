using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Autoradio
    {
        private double naladenyKmitocet = 100;
        private bool radioZapnuto = false;
        private Dictionary<int, double> predvolby = new Dictionary<int, double>();

      

        public void zapnoutRadio(bool x)
        {
            radioZapnuto = x;
        }

        public void nastavPredvolbu(int cislo, double kmitocet)
        {
            predvolby[cislo] = kmitocet;
        }

        public void preladNaPredvolbu(int cislo)
        {
            if (predvolby.ContainsKey(cislo))
            {
                naladenyKmitocet = predvolby[cislo];
            }
            else
                throw new Exception("Kmitocet nenalezen");
        }

        public override string ToString()
        {
            if (radioZapnuto)
            {
                return String.Format($"Radio je zapnuto, Naladeny kmitocet:{naladenyKmitocet}");
            }
            else
                return String.Format($"Radio je vypnuto");
        }
    }
}

