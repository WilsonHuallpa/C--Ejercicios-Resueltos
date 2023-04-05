using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejer_64_hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja c1 = new Caja();
            Caja c2 = new Caja();


            Negocio n1 = new Negocio(c1, c2);

            n1.Clientes.Add("wilson");
            n1.Clientes.Add("ariel");
            n1.Clientes.Add("nestor");
            n1.Clientes.Add("maxi");
            n1.Clientes.Add("tavo");

            Thread asignar = new Thread(n1.AsignarCaja);

            Thread c_01 = new Thread(c1.AtenderClientes);
            Thread c_02 = new Thread(c2.AtenderClientes);

            c_01.Name = "Caja_01";
            c_02.Name = "Caja_02";

            asignar.Start();
            asignar.Join();

            c_01.Start();
            c_02.Start();

            Console.ReadKey(); 


          


        }
    }
}
