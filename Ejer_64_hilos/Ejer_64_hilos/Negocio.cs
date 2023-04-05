using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Ejer_64_hilos
{
    public class Negocio
    {
        Caja caja1;
        Caja caja2;
        List<string> clientes;

        public Negocio(Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            clientes = new List<string>();
        }

        public Caja Caja1 { get => caja1;}
        public Caja Caja2 { get => caja2;}
        public List<string> Clientes { get => clientes; }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas....");

            foreach (string item in Clientes)
            {
                if (caja1.FilaClientes.Count() == 0 && caja2.FilaClientes.Count() == 0)
                {
                    caja1.FilaClientes.Add(item);
                }
                else if (caja1.FilaClientes.Count() < caja2.FilaClientes.Count())
                {
                    caja1.FilaClientes.Add(item);
                }
                else if (caja1.FilaClientes.Count() > caja2.FilaClientes.Count())
                {
                    caja2.FilaClientes.Add(item);
                }
                else
                {
                    caja1.FilaClientes.Add(item);
                }
               
                Thread.Sleep(1000);
            }
        }

    }
}
