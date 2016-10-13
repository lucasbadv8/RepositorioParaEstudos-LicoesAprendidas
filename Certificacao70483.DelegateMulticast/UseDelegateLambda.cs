using System;
using System.Security.Cryptography.X509Certificates;

namespace Certificacao70483.DelegateMulticast
{
    class UseDelegateLambda
    {
        public delegate int Calcular(int x, int y);

        public UseDelegateLambda()
        {
            Calcular calc = (i, i1) => i + i1;

            Console.WriteLine(calc(10 ,15));

            calc += (i, i1) => i*i1;

            Console.WriteLine(calc(20,30));
        }
    }
}
