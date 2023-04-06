using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_11
{
    internal class Validador
    {
        public static bool validador(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }
    }
}
