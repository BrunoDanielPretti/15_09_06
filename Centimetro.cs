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

        public static implicit operator Centimetro(float cant)
        {
            Centimetro valor = new Centimetro(cant);
            return valor;
        }

        public static implicit operator Centimetro(Metro cant)
        {
            Centimetro valor = new Centimetro(cant.Cantidad * 100);
            return valor;
        }
     
        public static Centimetro operator -(Metro met, Centimetro cent)
        {
            Centimetro resultado = new Centimetro();

            resultado.Cantidad = met.Cantidad * 100 - cent.Cantidad;

            return resultado;
        }

        public static Centimetro operator -(Centimetro cent, Metro met)
        {
            Centimetro resultado = new Centimetro();

            resultado.Cantidad = cent.Cantidad -  met.Cantidad * 100;

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

        public static bool operator ==(Metro met, Centimetro cent)
        {
            if (met.Cantidad == (cent.Cantidad / 100))
                return true;
            else
                return false;
        }

        public static bool operator !=(Metro met, Centimetro cent)
        {
            return !(met == cent);
        }

        public static bool operator <=(Metro met, Centimetro cent)
        {
            if (met.Cantidad <= (cent.Cantidad / 100))
                return true;
            else
                return false;
        }

        public static bool operator >=(Metro met, Centimetro cent)
        {
            return !(met <= cent);
        }
    }
}
