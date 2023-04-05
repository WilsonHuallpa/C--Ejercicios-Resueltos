using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejecicios
    {
        public static string MostrarMaxMinPromedio(int[] numeros)
        {
            int minimo = 0;
            int maximo = 0;
            int suma = 0;
            float promedio;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (minimo == 0 && maximo == 0)
                {
                    minimo = numeros[i];
                    maximo = numeros[i];
                }
                else if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }
                else if (numeros[i] < minimo)
                {
                    minimo = numeros[i];
                }
                suma = suma + numeros[i];
            }
            promedio = (float)suma / 5;

            return " maximo: " + maximo + " mimimo: " + minimo + "Promedio: " + promedio;
        }


        public static void MostrarNumeroPrimo(int n)
        {
            bool isprimo = true;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 2; j <= n; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isprimo = false;
                        break;
                    }
                }
                if (isprimo)
                {
                    Console.WriteLine("primo : " + i);
                }
                isprimo = true;
            }

        }

        public static void MostrarNumeroPerfecto(int num)
        {
            int b; int j;
            string divisores = "";
            for (int i = 1; i <= num; i++)
            {
                b = 0;

                for (j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        b += j;
                        divisores += " " + j + " ";
                    }
                }
                if (b == i)
                    Console.WriteLine("El numero " + i + " es perfecto y su divisores son: " + divisores);
                divisores = "";
            }
        }

        public static void CalcularElCentroNumerico(double numero)
        {
            // Variables
            double aumento = 1,
                i,
                j,
                sumaAtras,
                sumaAdelante;


            // Comienzo del programa
            while (aumento < numero)
            {

                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                // Calculo para atras
                for (i = 1; i < aumento; i++)
                {
                    sumaAtras = sumaAtras + i;
                }
                //calculo para adelante
                for (j = aumento + 1; j <= sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                        break;
                    sumaAdelante = sumaAdelante + j;
                }

                // Mostrando en pantalla
                if (sumaAtras == sumaAdelante)
                    Console.WriteLine("Es centro numerico: {0}", aumento);
            }
            Console.ReadLine();

        }
    }
}
