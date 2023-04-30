using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto: Vehiculo
    {
        private ETipo tipo;
        private static double valorHora;

        static Moto()
        {
            Moto.valorHora = 100;
        }
        public Moto(string patente, DateTime horaIngreso, ETipo tipo):base(patente, horaIngreso)
        {
            this.tipo = tipo;
        }
        public override double CostoEstadia 
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }
        public override string Descripcion 
        {
            get
            {
                return this.tipo.ToString();
            }
        }

        public static double ValorHora
        {
            set
            {
                double auxValorHora = value;
                if (auxValorHora >= 0)
                {
                    Moto.valorHora = auxValorHora;
                }
            }
        }

        protected override double CargoDeEstacionamiento()
        {
            double horas = base.CargoDeEstacionamiento();
            return (horas * valorHora);
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****MOTO*****");
            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"Tipo: {this.Descripcion}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public enum ETipo
        {
            Ciclomotor,
            Scooter,
            Sport
        }
    }
}
