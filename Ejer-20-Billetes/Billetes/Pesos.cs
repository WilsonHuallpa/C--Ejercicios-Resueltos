using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 398;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizRespectoDolar;
        }

        public static explicit operator Dolar(Pesos d)
        {
            return new Dolar(d.cantidad / Pesos.GetCotizacion());
        }
        public static explicit operator Euro(Pesos d)
        {
            return (Euro)((Dolar)d);
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }
        public static bool operator !=(Pesos d, Dolar e)
        {
            return !(d == e);
        }
        public static bool operator !=(Pesos d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator !=(Pesos d, Pesos e)
        {
            return !(d == e);
        }
        public static Pesos operator -(Pesos d, Dolar e)
        {
            return d.GetCantidad() - ((Pesos)e).GetCantidad();
        }
        public static Pesos operator -(Pesos d, Euro e)
        {
            return new Pesos(d.GetCantidad() - ((Pesos)e).GetCantidad());
        }
        public static Pesos operator +(Pesos d, Dolar e)
        {
            return new Pesos(d.GetCantidad() + ((Pesos)e).GetCantidad());
        }
        public static Pesos operator +(Pesos d, Euro e)
        {
            return new Pesos(d.GetCantidad() + ((Pesos)e).GetCantidad());
        }
        public static bool operator ==(Pesos d, Dolar e)
        {
            return (d.GetCantidad() == ((Pesos)e).GetCantidad());
        }
        public static bool operator ==(Pesos d, Euro e)
        {
            return (d.GetCantidad() == ((Pesos)e).GetCantidad());
        }
        public static bool operator ==(Pesos d, Pesos e)
        {
            return (d.GetCantidad() == e.GetCantidad());
        }


    }
}
