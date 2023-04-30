using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente { 

            get
            {
                if(this.clientes.Count > 0)
                {
                    return this.clientes.Dequeue();
                }
                return null;
            }
            set
            {
                bool retorno = this + value;
                
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return (this.clientes.Count > 0)? this.clientes.Count : 0;
            }
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            if( n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }
        public static bool operator -(Negocio n)
        {
            Cliente proximoAtende = n.Cliente;
            n.caja.Atender(proximoAtende);
            return true;
        }


    }
}
