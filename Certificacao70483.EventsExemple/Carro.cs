using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Certificacao70483.EventsExemple
{
    
    class Carro: Blaus
    {
        public event Action AlertaAltaVelocidade; 
        private double velocidade;

        public override void Virtualizado()
        {
            base.Virtualizado();
            BinaryFormatter a = new BinaryFormatter();

            
        }

        public void AcessarEvento()
        {
            
            AlertaAltaVelocidade?.Invoke();
        }

        public double Velocidade
        {
            protected get { return velocidade; }
            set
            {
                velocidade = value;
                if (velocidade >= 60)
                    AlertaAltaVelocidade?.Invoke();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }


    }

    public class Blaus
    {
            
        public virtual void Virtualizado()
        {
            
        }
        
    }
}
