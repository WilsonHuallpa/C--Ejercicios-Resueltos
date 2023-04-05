using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public enum TipoLlamada
    {
        Local, Provincial, Todas
    }

    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion { get => duracion;}
        public string NroDestino { get => nroDestino;}
        public string NroOrigen { get => nroOrigen;}

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {this.duracion}");
            sb.AppendLine($"Destino: {this.nroDestino}");
            sb.AppendLine($"Origen: {this.nroOrigen}");
            return sb.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return 1;
            /*OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. Se utilizará para
            ordenar una lista de llamadas de forma ascendente.*/

        }

    }
}
