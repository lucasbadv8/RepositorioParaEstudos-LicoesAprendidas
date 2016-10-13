namespace ExemploFilaPilha
{
    class ElementoPilha
    {
        public int Valor { get; set; }

        public ElementoPilha Proximo { get; set; }

        public ElementoPilha(int value)
        {
            Valor = value;
            Proximo = null;
        }
    }
}
