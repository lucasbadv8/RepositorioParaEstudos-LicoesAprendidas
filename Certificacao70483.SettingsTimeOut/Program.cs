using System;
using System.Threading;
using System.Threading.Tasks;

namespace Certificacao70483.SettingsTimeOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Task minhaTask = Task.Run(()=>
            {
                Thread.Sleep(15000);
            });

            int index = Task.WaitAny(new[] {minhaTask}, 12000);
            Console.WriteLine(index == -1 ? "Minha taks atingiu o tempo limite de espera" : "Tarefa concluida!");
            Console.ReadLine();
        }
    }
}
