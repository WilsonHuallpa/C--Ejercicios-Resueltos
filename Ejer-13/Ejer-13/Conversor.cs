using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_13
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero) 
        {
            if (numeroEntero == 0) 
            {
                return "0";
            }

            string resultado = "";

            while (numeroEntero > 0)
            {
                int resto = numeroEntero % 2;
                resultado = resto.ToString() + resultado;
                numeroEntero = numeroEntero / 2;
            }

            return resultado;

        }
        public static int ConvertirBinarioADecimal(int numeroEntero) 
        {
            int resultado = 0;
            int potenciaDeDos = 1;

            while (numeroEntero > 0)
            {
                int ultimoDigito = numeroEntero % 10;
                resultado += ultimoDigito * potenciaDeDos;
                potenciaDeDos *= 2;
                numeroEntero /= 10;
            }

            return resultado;

        }
    }
}
