using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }

        public float CostoLlamada { get => CalcularCosto() ; }

        private float CalcularCosto()
        {
            float costo = 0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = (float)(0.99 * duracion);
                    return costo;
                case Franja.Franja_2:
                    costo = (float)(1.25 * duracion);
                    return costo;
                case Franja.Franja_3:
                    costo = (float)(0.66 * duracion);
                    return costo;
                default:
                    return costo;
            }
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Llamada provincial");
            sb.AppendLine("---------------------------------------------------");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");
            sb.AppendLine("---------------------------------------------------");
            return sb.ToString();
        }
    }

}
