using System;
using static System.Console;
using System.Threading;
using System.Threading.Tasks;

namespace BanchMark.DisposePrivate
{
    class Resource : IDisposable
    {
        public Resource() { WriteLine("created ..."); }
        public void MetodoUm() { WriteLine("Foo"); }
        public void MetodoDois() { WriteLine("Fee"); }
        public void Dispose() { WriteLine("cleanup..."); }
    }

    class ResourceAutoDisposable
    {
        private ResourceAutoDisposable() {}

        public void Foo(int sleep)
        {
            Thread.Sleep(sleep * 100);
        }

        public void Fee(int sleep)
        {
            Thread.Sleep(sleep*1000);
            WriteLine("Fee - " + sleep);
        }
        private void Dispose(int sleep) { WriteLine("cleanup..." + sleep); }

        public static void Use(Action<ResourceAutoDisposable> block,int sleep)
        {
            var r = new ResourceAutoDisposable();
            try
            {
                WriteLine("Começando processo - " + sleep);
                block(r);
            }
            finally
            {
                r.Dispose(sleep);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Primeira Forma
            using (Resource recursos = new Resource())
            {
                recursos.MetodoUm();
                recursos.MetodoDois();
            }

            WriteLine("*******************");

            //ResourceAutoDisposable.Use(r => {
            //    r.Fee();
            //    r.Foo();
            //},1);
            
            Parallel.For(1, 10, i =>
            {
                ResourceAutoDisposable.Use(r => {
                    r.Fee(i);
                    r.Foo(i);
                },i);
            });

            ReadLine();
        }
    }
}
