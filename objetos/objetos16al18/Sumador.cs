﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos16al18
{
    class Sumador
    {
        private int cantidadSumas;
        
        public Sumador()
        {
            this.cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas) : this()
        {
            this.cantidadSumas = cantidadSumas;
        }
        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return a + b;
        }
        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }
        public static long operator + (Sumador s1 , Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }
        public static bool operator | (Sumador s1, Sumador s2)
        {
            if ( s1.cantidadSumas == s2.cantidadSumas )
            {
                return true;
            }
            return false;
        }
    }
}
