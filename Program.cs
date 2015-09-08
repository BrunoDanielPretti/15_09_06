using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_09_06
{
    /// <summary>
    /// Tomando como punto de partida a los ejemplos vistos:
    /// Sobrecargar: 
    /// -, *, / (Para Metro y Centímetro)
    /// ==, !=, <=, >= (para Metro y Centímetro)
    /// Poder asignar un objeto de tipo Metro a uno de tipo Centímetro (y viceversa).
    /// Realizar desde el Main, todas las operaciones aritméticas, operaciones de comparación y asignación. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Metro m1 = 10;
            Metro rtaMetro;
            Centimetro c1 = 200;
            Centimetro rtaCent;

            Console.WriteLine("Metros: " + m1.Cantidad + "   Centimetros: " + c1.Cantidad);
            Console.WriteLine("");
            //Metro rtaMetro = m1 - c1;
            //Console.WriteLine(rtaMetro.Cantidad);

            rtaCent = m1 - c1; 
            Console.WriteLine("Metros - Centimetros: " + rtaCent.Cantidad + " Cm");

            rtaCent = c1 - m1;
            Console.WriteLine("Centimetros - Metros: " + rtaCent.Cantidad + " Cm");

            rtaCent = m1 * c1;
            Console.WriteLine("Metros * Centimetros: " + rtaCent.Cantidad + " Cm");

            rtaCent = m1 / c1;
            Console.WriteLine("Metros / Centimetros: " + rtaCent.Cantidad + " Cm");

            Console.ReadKey();
        }
    }
}
