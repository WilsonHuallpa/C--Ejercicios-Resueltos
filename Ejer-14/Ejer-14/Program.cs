namespace Ejer_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primero numro: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primero numro: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("(ingresando el caracter +, -, * o /)");
            char operador = char.Parse( Console.ReadLine());

            int resultado = Calculadora.Calcular(num1, num2, operador);

            Console.WriteLine($"Resultado de la operacion: {resultado}");
            Console.ReadKey();
        }



        /*Realizar un programa que permita realizar operaciones matemáticas simples
         * (suma, resta, multiplicación y división).

        Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

        Calcular (público): Recibirá tres parámetros, el primer operando, el segundo
        operando y la operación matemática. El método devolverá el resultado de la operación.

        Validar (privado): Recibirá como parámetro el segundo operando. Este método
        se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método
        devolverá true si el operando es distinto de cero.

        Se le debe pedir al usuario que ingrese dos números y la operación que desea 
        realizar (ingresando el caracter +, -, * o /).

        El usuario decidirá cuándo finalizar el programa. */
    }
}