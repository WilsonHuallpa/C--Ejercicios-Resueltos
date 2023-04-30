using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;

        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.horaIngreso = horaIngreso;
        }

        public abstract double CostoEstadia { get; }
        public abstract string Descripcion { get; }
        public DateTime HoraEgreso {

            get
            {
                return this.horaEgreso;
            }
            set
            {
                DateTime auxHoraEgreso = value;
                if (DateTime.Compare(this.horaIngreso, auxHoraEgreso) < 0)
                {
                    this.horaEgreso = auxHoraEgreso;
                }
                else
                {
                    Console.WriteLine("Error! al ingresar hora de egreso");
                }
            }
        
        }
        public DateTime HoraIngreso { get => horaIngreso; }
        public string Patente
        {
            get { return this.patente; }
            set 
            {
                string auxPatente = value;
                bool validar = ValidarPatente(auxPatente);
                this.patente = (validar) ? auxPatente : "La pantente no es correcta";
            }
        }


        protected virtual double CargoDeEstacionamiento()
        {
            TimeSpan tiempoEstadia = this.horaEgreso - this.horaIngreso;
            double horasEstadia = tiempoEstadia.TotalHours;
            return horasEstadia;
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {this.patente} ");
            sb.AppendLine($"Hora de ingreso: {this.horaIngreso}");
            return sb.ToString();
        }
        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            return (v1.Patente == v2.Patente);
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        private bool ValidarPatente(string patente)
        {
            return (patente.Length >= 6 && patente.Length <= 7);
        }

        public enum EVehiculos
        {
            Automovil,
            Moto
        }
    }
}
