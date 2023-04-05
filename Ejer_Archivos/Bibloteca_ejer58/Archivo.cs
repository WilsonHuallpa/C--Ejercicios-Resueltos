using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bibloteca_ejer58
{
    [Serializable]
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta, bool validarExistencia)
        {
            if (validarExistencia && File.Exists(ruta))
            {
                return true; 
            }
            throw new FileNotFoundException("Error.... No exite el Archivo");
        }
    }
}
