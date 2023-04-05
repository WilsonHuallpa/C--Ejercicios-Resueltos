using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos16al18
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string name, string ape, int lega)
        {
            nombre = name;
            apellido = ape;
            legajo = lega;
        } 

        public void CalcularFinal()
        {
            if (nota1 > 4 && nota2 > 4)
            {
                Random rnd = new Random();
                notaFinal = rnd.Next(5, 10);
            }
            else
            {
                notaFinal = -1;
            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            nota1 = notaUno;
            nota2 = notaDos;
        }
        public string Mostrar()
        {
            string retorno;
            if (notaFinal != -1)
            {
                retorno = "nombre: " + nombre + " apellido: " + apellido + " notafinal: " + notaFinal;
            }
            else
            {
                retorno = "Alumno desaprobado";
            }
            return retorno;
        }

    }
}
