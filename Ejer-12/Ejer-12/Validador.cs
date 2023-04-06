using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_12
{
    internal class Validador
    {
        public static bool ValidarRespuesta(string palabra)
        {
            return palabra == "s" || palabra == "S";
        }
    }
}
