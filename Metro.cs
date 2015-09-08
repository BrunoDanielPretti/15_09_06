using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_09_06
{
    class Metro
    {
        public float Cantidad;

        public Metro()
        {
        }   

        public Metro(float cant)
        {
            this.Cantidad=cant;
        }

        public static Metro operator -(Metro met, Centimetro cent)
        {
            Metro resultado = new Metro();

            resultado.Cantidad = met.Cantidad - cent.Cantidad / 100;

            return resultado;
        }

        public static Metro operator *(Metro met, Centimetro cent)
        {
            Metro resultado = new Metro();
            
            resultado.Cantidad = met.Cantidad * (cent.Cantidad / 100);

            return resultado;
        }

        public static Metro operator /(Metro met, Centimetro cent)
        {
            Metro resultado = new Metro();

            resultado.Cantidad = met.Cantidad / (cent.Cantidad / 100);

            return resultado;
        }
    }
}
