namespace ExemploFilaPilha
{
    class Pilha
    {
        ElementoPilha _topo;

        public bool EstaVazia()
        {
            return _topo == null;
        }

        public void InsereFim(int valor)
        {
            var novo = new ElementoPilha(valor);
            if (EstaVazia())
                _topo = novo;
            else
            {
                novo.Proximo = _topo;
                _topo = novo;
            }
            
        }

        public int Remover()
        {
            int valor = this._topo.Valor;
            this._topo = this._topo.Proximo;
            return valor;
        }

        public int ValorTopo()
        {
            return _topo.Valor;
        }

        public int Tamanho()
        {
            int tam = 0;
            ElementoPilha aux = _topo;

            while (aux != null)
            {
                tam++;
                aux = aux.Proximo;
            }
            return tam;
        }
    }
}
