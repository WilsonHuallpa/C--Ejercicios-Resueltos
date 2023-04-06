namespace Ejer_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**** Ejercicio 01 ******/
            int valor = 10;
            int minimo = 0;
            int maximo = 0;
            int suma = 0;
            float promedio;
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Ingrese un numero:");
                valor = int.Parse(Console.ReadLine());
                while (!Validador.validador(valor, -100, 100))
                {
                    Console.WriteLine("Error!! Ingrese un numero entero:");
                    valor = int.Parse(Console.ReadLine());
                }
                if (minimo == 0 && maximo == 00)
                {
                    minimo = valor;
                    maximo = valor;
                }
                else if (valor > maximo)
                {
                    maximo = valor;
                }
                else if (valor < minimo)
                {
                    minimo = valor;
                }
                suma = suma + valor;
            }
            promedio = (float)suma / 10;
            Console.WriteLine($"minimo: {minimo}, Maximo: {maximo}, Promedio: {promedio}");
            Console.ReadLine();
        }
    }
}