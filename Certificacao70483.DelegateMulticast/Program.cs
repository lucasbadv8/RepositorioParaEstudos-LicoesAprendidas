using System;

namespace Certificacao70483.DelegateMulticast
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Multicast();
            c.TudoJunto();

            Console.WriteLine("************");

            var o = new UseDelegateLambda();

            Console.WriteLine("************");

            var a = new UseAction();
            Console.ReadLine();
        }
    }
}
