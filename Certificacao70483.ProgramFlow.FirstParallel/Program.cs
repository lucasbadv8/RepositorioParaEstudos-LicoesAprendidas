using System;
using System.Threading;
using System.Threading.Tasks;

namespace Certificacao70483.ProgramFlow.FirstParallel
{
    class Program
    {
        static void Main()
        {

            Parallel.For(0, 1000, i =>
            {
                Console.WriteLine("{0} X {1} = {2}",i,i,i*i);
                Thread.Sleep(1000);
            });
        }
    }
}
