using System;

namespace Certificacao70483.ExceptionsHandlings.TEste
{
    class ConcatenaNome : IDisposable
    {
        public string ConcatenarNomes(string nome,string sobrenome)
        {

            if(string.IsNullOrWhiteSpace(nome))
                throw new ArgumentNullException($"Nome");

            return string.Format($"{nome} {sobrenome}");
        }

        public void Dispose()
        {
            GC.Collect();
            GC.SuppressFinalize(this);
        }
    }
}
