using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificacao70483.DelegateMulticast
{
    class Multicast
    {
        public delegate void Deleg();

        public void FazAlgoUm()
        {
            Console.WriteLine("Fazendo algo 1");
        }

        public void FazAlgoDois()
        {
            Console.WriteLine("Fazendo algo 2");
        }

        public void TudoJunto()
        {
            Deleg d = FazAlgoDois;
            d += FazAlgoUm;
            d();
        }
    }
}
