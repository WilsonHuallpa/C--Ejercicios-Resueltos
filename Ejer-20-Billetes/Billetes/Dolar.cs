using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator !=(Dolar d, Pesos e)
        {
            return !(d == e);
        }
        public static bool operator !=(Dolar d, Dolar e)
        {
            return !(d == e);
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return d.GetCantidad() - ((Dolar)e).GetCantidad();
        }
        public static Dolar operator -(Dolar d, Pesos e)
        {
            return d.GetCantidad() - ((Dolar)e).GetCantidad();
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return d.GetCantidad() + ((Dolar)e).GetCantidad();
        }
        public static Dolar operator +(Dolar d, Pesos e)
        {
            return d.GetCantidad() + ((Dolar)e).GetCantidad();
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.GetCantidad() == e.GetCantidad());
        }
        public static bool operator ==(Dolar d, Pesos e)
        {
            return (d.GetCantidad() == e.GetCantidad());
        }
        public static bool operator ==(Dolar d, Dolar e)
        {
            return (d.GetCantidad() == e.GetCantidad());
        }
    }
}
