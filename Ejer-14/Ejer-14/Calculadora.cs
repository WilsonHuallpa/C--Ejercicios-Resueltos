using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_14
{
    public class Calculadora
    {
        public static int Calcular(int op1, int op2, char operador )
        {
            int resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado = op1 + op2;
                    break;
                case '-':
                    resultado = op1 - op2;
                    break;
                case '/':
                    if (Validar(op2))
                    {
                        resultado = op2 / op1;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir con 0");
                        resultado = 0;
                    }
                    
                    break;
                case '*':
                    resultado = op1 * op2;
                    break;
                default:
                    Console.WriteLine("No este un operador correcto, retorna 0.");
                    break;
            }
            return resultado;
        }
        private static bool Validar(int op2)
        {
            return op2 != 0;
        }
    }
}
