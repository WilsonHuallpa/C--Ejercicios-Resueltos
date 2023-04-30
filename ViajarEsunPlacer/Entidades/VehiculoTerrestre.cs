using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class VehiculoTerrestre
    {

        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;
        protected short cantidadMarchas;

        protected VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        protected VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas) : this(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
        }

        public short CantidadRuedas { get => cantidadRuedas; set => cantidadRuedas = value; }
        public short CantidadPuertas { get => cantidadPuertas; set => cantidadPuertas = value; }
        public Colores Color { get => color; set => color = value; }
        public short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas = value; }
    }
}
