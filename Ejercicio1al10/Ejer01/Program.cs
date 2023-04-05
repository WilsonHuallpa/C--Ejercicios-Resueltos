using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el
            //valor máximo, el valor mínimo y el promedio
            /*
            int[] numeros=new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese numero:");
                int num =  int.Parse(Console.ReadLine());
                numeros[i] = num;
            }
            Console.WriteLine(Ejecicios.MostrarMaxMinPromedio(numeros));
            Console.Read();
            */

            //2.Ingresar un número y mostrar: el cuadrado y el cubo del mismo.Se debe validar que el número sea
            //mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
            //Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
            /*
            int numero;
            double cuadrado;
            double cubo;

            Console.WriteLine("ingrese un numero?");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                cuadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("numero: " + numero + " cuadrado: " + cuadrado + " cubo: " + cubo);
            }
            else
            {
                Console.WriteLine("ERROR.¡Reingresar numero!");
            }
            Console.Read();
            */

            //3. Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
            //por consola.
            //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).   
            /*
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            Ejecicios.MostrarNumeroPrimo(numero);
            Console.Read();*/

            //4.Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
            //(excluido el mismo) que son divisores del número.
            //El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            //Escribir una aplicación que encuentre los 4 primeros números perfectos.
            //Nota: Utilizar estructuras repetitivas y selectivas
            /*
            Console.Write("Determine hasta que numero desea realizar la busqueda de numeros perfectos: ");
            int num = int.Parse(Console.ReadLine());
            Ejecicios.MostrarNumeroPerfecto(num);
            Console.ReadKey();
            */

            /*
             5. Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en 
                dos grupos de números, cuyas sumas son iguales.
                El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) 
                cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 
                49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
                Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el 
                usuario ingrese por consola.
                Nota: Utilizar estructuras repetitivas y selectivas
             */

            /*
            Console.Title = "Ejercicio 05";
            Console.WriteLine("Calculo centro numerico\n" +
                              "-----------------------");
            Console.Write("Ingrese un numero (ejemplo: 10000): ");
            double numero = double.Parse(Console.ReadLine());

            Ejecicios.CalcularElCentroNumerico(numero);
            Console.Read();*/



            /*Escribir un programa que determine si un año es bisiesto.

            Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 
            no son bisiestos, salvo si ellos también son múltiplos de 400. 
            Por ejemplo: el año 2000 es bisiesto pero 1900 no.

            Pedirle al usuario un año de inicio y otro de fin y mostrar 
            todos los años bisiestos en ese rango.*/

            //Console.WriteLine("Ingrese el año de inicio:");
            //int startYear = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el año final:");
            //int endYear = int.Parse(Console.ReadLine());

            //Console.WriteLine("Años bisiestos entre " + startYear + " y " + endYear + ":");

            //for (int year = startYear; year <= endYear; year++)
            //{
            //    if (IsLeapYear(year))
            //    {
            //        Console.WriteLine(year);
            //    }
            //}

            //Console.ReadKey();

            //terminar ejercicio 7 8  10.

        }
        /*06*/
        static bool IsLeapYear(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }
            else if (year % 100 != 0)
            {
                return true;
            }
            else if (year % 400 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
    
}
