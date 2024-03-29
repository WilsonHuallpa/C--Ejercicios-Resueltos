﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        protected float costo;

        public Local(string origen, float duracion, string destino, float costo) : base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public float CostoLlamada { get => CalcularCosto();}

        private float CalcularCosto()
        {
            return (float)(costo * duracion);
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Llamada Local");
            sb.AppendLine("---------------------------------------------------");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {this.costo}");
            sb.AppendLine("---------------------------------------------------");
            return sb.ToString();
        }


    }
}
