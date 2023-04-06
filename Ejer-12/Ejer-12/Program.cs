namespace Ejer_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar;
            int contador = 0;
            do
            {

                Console.WriteLine("Ingrese numero:");
                int numero = int.Parse(Console.ReadLine());
                contador += numero;
                Console.WriteLine("¿Desea continuar? (S/N)");
                string resp = Console.ReadLine();
                continuar = Validador.ValidarRespuesta(resp);

            } while (continuar);

            Console.WriteLine($"Numero sumado: {contador}");
            Console.ReadKey();
        }
    }
}