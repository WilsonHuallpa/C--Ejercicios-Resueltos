using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;
        
        private Estacionamiento(string nombre, int capacidad)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
        }
        public List<Vehiculo> ListadoVehiculos
        {
            get
            {
                return this.listadoVehiculos;
            }
        }

        public string Nombre { 
            get
            {
                return this.nombre;
            }
        }

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if(estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }
            return estacionamiento;
        }
        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Estacionamiento {this.nombre}*****");
            sb.AppendLine($"{vehiculo}");
            return sb.ToString();
        }
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach(Vehiculo auxVehiculo in estacionamiento.listadoVehiculos)
            {
                if (auxVehiculo == vehiculo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento.listadoVehiculos.Count < estacionamiento.capacidadEstacionamiento && estacionamiento != vehiculo)
            {
                estacionamiento.listadoVehiculos.Add(vehiculo);
                return true;
            }
            return false;
        }
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                estacionamiento.listadoVehiculos.Remove(vehiculo);
                return true;
            }
            return false;
        }
    }
}
