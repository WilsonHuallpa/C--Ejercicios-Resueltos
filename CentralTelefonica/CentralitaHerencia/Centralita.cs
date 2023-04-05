using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamada;

        protected string razonSocial;

        public float GananciaPorLocal { get => CalcularGanancia(TipoLlamada.Local); }
        public float GananciaPorProvincial { get => CalcularGanancia(TipoLlamada.Provincial); }
        public float GananciaPorTotal { get => CalcularGanancia(TipoLlamada.Todas); }
        public List<Llamada> Llamadas { get => listaDeLlamada; }

        private float CalcularGanancia(TipoLlamada tipo ) {
            float recaudado = 0;
            switch (tipo) { 
                 case TipoLlamada.Local:
                    foreach (Local local in listaDeLlamada)
                    {
                        recaudado += local.CostoLlamada;
                    }
                    break;
                 case TipoLlamada.Provincial:
                    foreach (Provincial pro in listaDeLlamada)
                    {
                        recaudado += pro.CostoLlamada;
                    }
                    break;
                 case TipoLlamada.Todas:
                    foreach (Local local in listaDeLlamada)
                    {
                        recaudado += local.CostoLlamada;
                    }
                    foreach (Provincial pro in listaDeLlamada)
                    {
                        recaudado += pro.CostoLlamada;
                    }
                    break;
                 default:
                    return recaudado;
            }
            return recaudado;
        }
        public Centralita()
        {
            listaDeLlamada = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Gananacias de llamadas");
            sb.AppendLine("---------------------------------------------------");
            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine("---------------------------------------------------");
            sb.AppendLine($"LOCAL: {this.GananciaPorLocal}" );
            sb.AppendLine($"PROVINCIAL: {this.GananciaPorProvincial}");
            sb.AppendLine($"TODOS: {this.GananciaPorTotal}");
            sb.AppendLine("---------------------------------------------------");
            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            foreach (Llamada llamada in listaDeLlamada)
            {
                Console.WriteLine(llamada.Mostrar());
            }
        }
    }
}
