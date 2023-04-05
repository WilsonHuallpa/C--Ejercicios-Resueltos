using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejer_64_hilos
{
    public class Caja
    {
        List<string> filaClientes;

        public List<string> FilaClientes { get => filaClientes;}

        public Caja()
        {
            filaClientes = new List<string>();
        }
        public void AtenderClientes()
        {
            foreach (string item in filaClientes)
            {
                Console.WriteLine("Cliente: " + item + " Caja: " + Thread.CurrentThread.Name);
                Thread.Sleep(2000);
            }
        }

    }
}
