using Billetes;
namespace Ejer_20_Billetes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pesos peso = 398;
            //Dolar dolar = (Dolar)peso;
            //Console.WriteLine(dolar.GetCantidad());
            Dolar dolar1 = new Dolar(323);
            Pesos pesos = new Pesos(232);
            Dolar d = dolar1 + pesos;

            Console.WriteLine(d.GetCantidad());

            Console.ReadKey();
        }
    }
}