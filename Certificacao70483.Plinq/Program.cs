using System;
using System.Linq;

namespace Certificacao70483.Plinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Enumerable.Range(0, 1000);
            var parallelResult = number.AsParallel().Where(i => i%2 == 0).ToArray();

            foreach (var i in parallelResult)
            {
                Console.WriteLine(i);
            }

            parallelResult = number.AsParallel().AsSequential().ToArray();

            foreach (var i in parallelResult)
            {
                Console.WriteLine(i);
            }

            parallelResult = number.AsParallel().AsOrdered().ToArray();

            foreach (var i in parallelResult)
            {
                Console.WriteLine(i);
            }
        }
    }
}
