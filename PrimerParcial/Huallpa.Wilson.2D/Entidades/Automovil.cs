using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil:Vehiculo
    {
        private string marca;
        private static double valorHora;

        
        static Automovil()
        {
            valorHora = 120;
        }
        public Automovil(string patente, DateTime horaIngreso, string marca):base(patente, horaIngreso)
        {
            this.marca = marca;
        }
        public override double CostoEstadia
        {
            get
            {
                return CargoDeEstacionamiento();
            }
        }

        public override string Descripcion
        {
            get
            {
                return this.marca;
            }
        }
        public static double ValorHora
        {
            set
            {
                double auxValorHora = value;
                if(auxValorHora >= 0)
                {
                    Automovil.valorHora = auxValorHora;
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
            sb.AppendLine("****AUTOMOVIL*****");
            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"Marca: {this.Descripcion}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
