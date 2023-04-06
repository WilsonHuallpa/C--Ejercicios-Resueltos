using System.Text;

namespace Ejer_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!!");
            Console.WriteLine("Ingrese Un numero: ");
            int num = int.Parse(Console.ReadLine());

            string resultado = MostrarTabla(num);
            Console.WriteLine(resultado);
            Console.ReadLine();
        }

        public static string MostrarTabla(int num)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                sb.AppendLine($"{num} x {i} = { num * i }");
            }
            return sb.ToString();
             
        }
        /*Consigna
         * 
        Crear una aplicación de consola que permita al usuario ingresar un número entero.

        Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

        Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

        Mostrar en la consola el resultado.

        Por ejemplo, si se ingresa el número 2 la salida deberá ser:*/
    }
}