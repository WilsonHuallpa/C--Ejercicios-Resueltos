using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca_ejer58
{
    public interface IArchivos<T>
    {
        bool Guardar(string ruta, T objeto);

        bool GuardarComo(string ruta, T objeto);

        T Leer(string ruta);
    }
}
