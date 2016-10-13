using System;

namespace Certificacao70483.Equality
{
    class UseDelegate
    {
        public delegate int Calcular(int x,int y);

        public int Somar(int x, int y)
        {
            return x + y;
        }

        public int Multiplicar(int x, int y)
        {
            return x*y;
        }

        public UseDelegate()
        {
            Calcular calc = Somar;
            Console.WriteLine(calc(2,20));
            calc = Multiplicar;
            Console.WriteLine(calc(2, 20));
        }
        
    }
}
