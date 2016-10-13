using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BenchMark.Yield
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Buscando apenas os 5 resultados de uma lista " +
                              "com 99999999 resultados do Fibonacci");
            var tempo = new Stopwatch();
            Console.WriteLine("***********************");
            Console.WriteLine("******Sem yield********");
            tempo.Start();
            foreach (var fib in Fibonacci().Skip(1).Take(5))
            {
                Console.Write(fib + ", ");
            }
            tempo.Stop();
            Console.WriteLine();
            Console.WriteLine("Executou em {0}ms", tempo.ElapsedMilliseconds);
            Console.WriteLine("***********************");

            Console.WriteLine("******Com yield********");
            tempo.Restart();
            foreach (var fib in FibonacciGenerator().Skip(1).Take(5))
            {
                Console.Write(fib + ", ");
            }
            tempo.Stop();
            Console.WriteLine();
            Console.WriteLine("Executou em {0}ms", tempo.ElapsedMilliseconds);
            Console.WriteLine("***********************");
            Console.ReadLine();
        }

        static IEnumerable<int> Fibonacci()
        {
            var fibs = new List<int>();
            for (int i = 0, anterior = -1, atual = 1; i < 99999999; i++)
            {
                var novo = anterior + atual;
                anterior = atual;
                atual = novo;
                fibs.Add(novo);
            }
            return fibs;
        }

        static IEnumerable<int> FibonacciGenerator()
        {
            for (int i = 0, anterior = -1, atual = 1; i < 99999999; i++)
            {
                var novo = anterior + atual;
                anterior = atual;
                atual = novo;
                yield return novo;
            }
        }
    }
}
