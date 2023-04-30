using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 0.9;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro d)
        {
            return new Dolar(d.cantidad / Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Euro d)
        {
            return (Pesos)((Dolar)d);
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return  Euro.cotizRespectoDolar;
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        public static bool operator !=(Euro d, Dolar e)
        {
            return !(d == e);
        }
        public static bool operator !=(Euro d, Pesos e)
        {
            return !(d == e);
        }
        public static bool operator !=(Euro d, Euro e)
        {
            return !(d == e);
        }
        public static Euro operator -(Euro d, Dolar e)
        {
            return d.GetCantidad() - ((Euro)e).GetCantidad();
        }
        public static Euro operator -(Euro d, Pesos e)
        {
            return d.GetCantidad() - ((Euro)e).GetCantidad();
        }
        public static Euro operator +(Euro d, Dolar e)
        {
            return d.GetCantidad() + ((Euro)e).GetCantidad();
        }
        public static Euro operator +(Euro d, Pesos e)
        {
            return d.GetCantidad() - ((Euro)e).GetCantidad();
        }
        public static bool operator ==(Euro d, Dolar e)
        {
            return (d.GetCantidad() == e.GetCantidad());
        }
        public static bool operator ==(Euro d, Pesos e)
        {
            return (d.GetCantidad() == e.GetCantidad());
        }
        public static bool operator ==(Euro d, Euro e)
        {
            return (d.GetCantidad() == e.GetCantidad());
        }
      
      
    }
}
