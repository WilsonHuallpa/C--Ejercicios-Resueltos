using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
namespace Bibloteca_ejer58
{
    [Serializable]
    public class PuntoDat: Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        public PuntoDat()
        {
        }

        public string Contenido { get => contenido; set => contenido = value; }

        public bool Guardar(string ruta, PuntoDat objecto)
        {
            try
            {
                if (!string.IsNullOrEmpty(ruta) && !string.IsNullOrEmpty(objecto.Contenido))
                {
                    using (Stream fs = new FileStream(ruta, FileMode.Create))
                    {
                        BinaryFormatter ser = new BinaryFormatter();
                        ser.Serialize(fs, objecto);
                        return true;
                    }

                }
            }
            catch (ArchivoIncorrectoException e)
            {
                throw new ArchivoIncorrectoException("error", e);
            }
            return false;
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            try
            {
                using (Stream fs = new FileStream(ruta, FileMode.Create))
                {
                     BinaryFormatter ser = new BinaryFormatter();
                     ser.Serialize(fs, objeto);
                     return true;
                 }
            }
            catch (ArchivoIncorrectoException e)
            {
                throw new ArchivoIncorrectoException("error", e);
            }
         
        }

        public PuntoDat Leer(string ruta)
        {
            try
            {
                if (this.ValidarArchivo(ruta, true))
                {
                    using (Stream fs = new FileStream(ruta, FileMode.Open))
                    {
                        PuntoDat aux = new PuntoDat();
                        BinaryFormatter ser = new BinaryFormatter();
                        aux = (PuntoDat)ser.Deserialize(fs);
                        return aux;
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
                if (extension != ".dat")
                {
                    throw new ArchivoIncorrectoException("Es archivo no es un dat");
                }
                return base.ValidarArchivo(ruta, validarExistencia);
            }
            catch (FileNotFoundException e )
            {
                throw new ArchivoIncorrectoException("El Archivo no es correcto.", e);
            }
        }


    }
}
