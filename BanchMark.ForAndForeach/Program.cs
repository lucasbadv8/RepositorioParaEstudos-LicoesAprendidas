
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BanchMark.ForAndForeach
{
    class Program
    {
        private static List<int> lista; 
        private static int[] array;
        private static HashSet<int> hashSet;
        
        static void Main(string[] args)
        {
            int tamanho = 99999;
            int repetir = 10000;
            CriarCasos(tamanho);
            ForeachVsFor(repetir);
            tamanho = 99999;
            repetir = 1000;
            CriarCasos(tamanho);
            ForeachVsFor(repetir);
            Console.ReadLine();
        }

        private static void ForeachVsFor(int repetir)
        {
            int test = 0;
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < repetir; i++)
            {
                foreach (var o in array)
                {
                    test = i + i;
                }
            }
            watch.Stop();
            Console.WriteLine($"Foreach/Array {repetir} vezes: {watch.ElapsedMilliseconds}ms");

            watch = Stopwatch.StartNew();
            for (int i = 0; i < repetir ;i++)
            {
                for (int j = 0; j < array.Length;j++)
                {
                    test = i + i;
                }
            }
            watch.Stop();
            Console.WriteLine($"For/Array {repetir} vezes: {watch.ElapsedMilliseconds}ms");

            watch = Stopwatch.StartNew();
            for (int i = 0; i < repetir; i++)
            {
                foreach (var o in lista)
                {
                    test = i + i;
                }
            }
            watch.Stop();
            Console.WriteLine($"Foreach/Lista {repetir} vezes: {watch.ElapsedMilliseconds}ms");

            watch = Stopwatch.StartNew();
            for (int i = 0; i < repetir; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    test = i + i;
                }
            }
            watch.Stop();
            Console.WriteLine($"For/Lista {repetir} vezes: {watch.ElapsedMilliseconds}ms");

            watch = Stopwatch.StartNew();
            for (int i = 0; i < repetir; i++)
            {
                foreach (var o in hashSet)
                {
                    test = i + i;
                }
            }
            watch.Stop();
            Console.WriteLine($"Foreach/HashSet {repetir} vezes: {watch.ElapsedMilliseconds}ms");

            watch = Stopwatch.StartNew();
            for (int i = 0; i < repetir; i++)
            {
                for (int j = 0; j < hashSet.Count; j++)
                {
                    test = i + i;
                }
            }
            watch.Stop();
            Console.WriteLine($"For/HashSet {repetir} vezes: {watch.ElapsedMilliseconds}ms");

        }

        private static void CriarCasos(int tamanho)
        {
            Console.WriteLine("***************************************");
            //Console.WriteLine("*********   Criando Casos  ************");
            ////Console.WriteLine("***************************************");

            lista = new List<int>(tamanho);
            Random random = new Random();
            Stopwatch watch = Stopwatch.StartNew();
            Parallel.For(1, tamanho, i =>
            {
                lista.Add(random.Next(tamanho));
            });
            watch.Stop();
            //Console.WriteLine("{1} Casos criados em: {0}ms", watch.ElapsedMilliseconds,tamanho);
            array = lista.ToArray();
            hashSet = new HashSet<int>(lista);
        }
    }
}
