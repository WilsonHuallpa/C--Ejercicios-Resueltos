using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_16
{
    public class CalculadoraDeArea
    {
        public double CalcularAreaCuadrado(double longitudLado)
        {
            double area = Math.Pow(longitudLado, 2);
            return area;
        }
        public double CalcularAreaTriangulo(double base1, double altura) 
        {
            return (base1 * altura) / 2;
        } 
         

        public double CalcularAreaCirculo(double radio)
        {
            double pi = 3.14159; // pi value can be adjusted according to the required precision
            double area = pi * (radio * radio);
            return area;
        }
    }
}
