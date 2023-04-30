using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        
        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public int NumeroActual {
            get
            {
                return numeroActual + 1;
            }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(3000);
            return true;
        }

        public enum Puesto
        {
            Caja1,
            Caja2
        }
    }
}
