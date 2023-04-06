using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_17_Boligrafo
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor { get => color; }
        public short GetTinta { get => tinta; }

        public bool Pintar(short gasto, out string dibujo)
        {
            //short tintaAntes = 
            //this.SetTinta(gasto);
            //if (this.tinta > 0)
            //{

            //}
        }
        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }
        private void SetTinta(short tinta)
        {
            this.tinta += tinta;
            if(this.tinta < 0)
            {
                this.tinta = 0;
            }
            else if (this.tinta >= cantidadTintaMaxima)
            {
                Recargar();
            }
        }
    }
}
