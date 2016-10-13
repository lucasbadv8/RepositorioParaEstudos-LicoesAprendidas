using System;
using System.Threading.Tasks;

namespace Certificacao70483.ProgramFlow.TasksLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            object _lock = new object();
            Task minhaTask = Task.Run(() =>
            {
                for (var i = 0; i < 1000000; i++)
                    lock (_lock)
                    {
                        n++;
                    }
                    
            });

            for (int i = 0; i < 1000000; i++)
                lock (_lock)
                {
                    n--;
                }

            minhaTask.Wait();
            Console.WriteLine(n);
        }
    }
}
