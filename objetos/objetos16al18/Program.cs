using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos16al18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             //EJERCICIO 16
            Alumno alumno1 = new Alumno("wilson", "huallpa", 123);
            Alumno alumno2 = new Alumno("ariel", "huallpa", 456);
            Alumno alumno3 = new Alumno("jona", "hualla", 345);

            alumno1.Estudiar(7,9);
            alumno2.Estudiar(4, 3);
            alumno3.Estudiar(8, 5);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
            Console.Read();
            */

            //EJERCICIO 18 sobre cargas de operadores.
            Sumador sumas = new Sumador();
            Sumador suma1 = new Sumador(4);
            long sum = sumas.Sumar(2,4);
            long sum2 = sumas.Sumar(2, 4);
            long sum4 = sumas.Sumar(2, 4);
            long sum5 = sumas.Sumar(2, 4);
            string caract = sumas.Sumar("hola ", "mundo");

            Console.WriteLine((int)sumas);
            Console.WriteLine(sumas + suma1);
            Console.WriteLine(sumas | suma1);

            Console.Read();
        }
    }
}
