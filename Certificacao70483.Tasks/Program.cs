using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using static System.Console;

namespace Certificacao70483.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> colecao = new BlockingCollection<string>();

            Task read = Task.Run(() =>
            {
                while (true)
                {
                    WriteLine(colecao.Take());
                    foreach (string v in colecao.GetConsumingEnumerable())
                        WriteLine(v);
                }
            });


#line 26

            var coisa = new Distancia();


            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = ReadLine();
                    if (string.IsNullOrWhiteSpace(s))
                    {
                        break;
                    }
                    colecao.Add(s);
                }
            });
            write.Wait();
        }
    }

    public class Distancia
    {
        public double Valor { get; set; }

    }
}
