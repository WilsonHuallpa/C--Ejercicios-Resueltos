namespace Ejer_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero Decimal:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine(Conversor.ConvertirDecimalABinario(numero));
            Console.ReadKey();

            Console.WriteLine("Ingrese un nuemero Binario:");
            int binario = int.Parse(Console.ReadLine());

            Console.WriteLine(Conversor.ConvertirBinarioADecimal(binario));

            Console.ReadKey();
        }
    }
}