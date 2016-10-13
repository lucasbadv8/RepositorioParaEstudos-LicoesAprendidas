using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploFilaPilha
{
    class ElementoFila
    {
        int valor;
        public int Valor {
            get { return valor; }
            set { valor = value; }
        }
        ElementoFila proximo;

        public ElementoFila Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }

        public ElementoFila(int value)
        {
            valor = value;
            proximo = null;
        }
    }
}
