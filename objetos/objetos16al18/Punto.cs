using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos16al18
{
    class Punto
    {
        private int x;
        private int y;

        public int GetX
        {
            get{ return x; }
        }
        public int GetY
        {
            get { return y; }
        }

        public Punto(int x, int y)
        {
            this.y = y;
            this.x = y;
        }

    }
}
