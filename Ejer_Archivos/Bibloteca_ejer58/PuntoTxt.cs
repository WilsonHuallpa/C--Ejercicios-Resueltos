using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bibloteca_ejer58
{
    public class PuntoTxt :Archivo,IArchivos<string>
    {

        public bool Guardar(string ruta, string objeto)
        {

            try
            {
                if (!string.IsNullOrEmpty(ruta) && !string.IsNullOrEmpty(objeto))
                {
                    using (StreamWriter sw = new StreamWriter(ruta, true))
                    {
                        sw.WriteLine(objeto);
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                throw new ArchivoIncorrectoException("Error al intentar guardar archivo de texto");
            }
            return false;
        }

        public bool GuardarComo(string ruta, string objeto)
        {
            return true;
        }

        public string Leer(string ruta)
        {
            try
            {
                if (this.ValidarArchivo(ruta, true))
                {
                    string datos = String.Empty;
                    using (StreamReader sr = new StreamReader(ruta))
                    {
                        datos = sr.ReadToEnd();
                        return datos;
                    }
                }
                throw new ArchivoIncorrectoException("Archivo incorrecto.");
            }
            catch (ArchivoIncorrectoException e)
            {
                throw new ArchivoIncorrectoException("Error al intentar leer archivo .dat", e);
            }
        }

        protected override bool ValidarArchivo(string ruta, bool validarExistencia)
        {
            try
            {
                string auxArchivo = Path.GetFileName(ruta);
                string extension = Path.GetExtension(auxArchivo);

                if (extension != ".txt")
                {
                    throw new ArchivoIncorrectoException("Es archivo no es un txt");
                }

                return base.ValidarArchivo(ruta, validarExistencia);

            }
            catch (FileNotFoundException e)
            {
                throw new FieldAccessException("Error.", e);
            }
        }

    }
}
