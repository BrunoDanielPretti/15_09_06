using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_09_06
{
    class Centimetro
    {
        public float Cantidad;

        public Centimetro()
        {
        }

        public Centimetro(float cant)
        {
            this.Cantidad=cant;
        }

        /*
        public static Centimetro operator -(Metro met, Centimetro cent)
        {
            Centimetro resultado = new Centimetro();

            resultado.Cantidad = met.Cantidad * 100 - cent.Cantidad;

            return resultado;
        }

        public static Centimetro operator *(Metro met, Centimetro cent)
        {
            Centimetro resultado = new Centimetro();

            resultado.Cantidad = (met.Cantidad * 100) * cent.Cantidad;

            return resultado;
        }

        public static Centimetro operator /(Metro met, Centimetro cent)
        {
            Centimetro resultado = new Centimetro();

            resultado.Cantidad = (met.Cantidad * 100) / cent.Cantidad;

            return resultado;
        }
          */
    }
}
