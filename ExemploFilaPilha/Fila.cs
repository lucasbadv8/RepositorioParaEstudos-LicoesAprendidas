
namespace ExemploFilaPilha
{
    class Fila
    {
        ElementoFila inicio, fim;

        public bool EstaVazia()
        {
            return inicio == null;
        }

        public void InsereFim(int valor)
        {
            ElementoFila novo=new ElementoFila(valor);
            if (EstaVazia())
            {
                inicio = novo;
                fim = novo;
            }
            else
            {
                fim.Proximo = novo;
                fim = novo;
            }
        }

        public int RemoveFila()
        {
            int valor = inicio.Valor;
            inicio = inicio.Proximo;
            return valor;
        }

        public int Frente()
        {
            return inicio.Valor;
        }

        public int Tamanho()
        {
            int tam = 0;
            ElementoFila aux = inicio;

            while (aux != null)
            {
                tam ++;
                aux = aux.Proximo;
            }
            return tam;
        }
    }
}
