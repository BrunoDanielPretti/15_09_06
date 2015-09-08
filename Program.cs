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
            Centimetro c1 = 100;
            Centimetro rtaCent;

            Console.WriteLine("Metros: " + m1.Cantidad + "   Centimetros: " + c1.Cantidad);
            Console.WriteLine("");

           
           

            rtaMetro = m1 - c1;
            rtaCent = m1 - c1;
            Console.WriteLine("Metros - Centimetros: " + rtaCent.Cantidad + " Cm o " + rtaMetro.Cantidad + "m" );

            rtaMetro = c1 - m1;
            rtaMetro = rtaCent;
            Console.WriteLine("Centimetros - Metros: " + rtaCent.Cantidad + " Cm o " + rtaMetro.Cantidad + "m");

            rtaMetro = m1 * c1;
            rtaCent = m1 * c1;
            Console.WriteLine("Metros * Centimetros: " + rtaCent.Cantidad + " Cm o " + rtaMetro.Cantidad + "m");

            
            rtaCent = m1 / c1;
            rtaMetro = rtaCent;
            Console.WriteLine("Metros / Centimetros: " + rtaCent.Cantidad + " Cm o " + rtaMetro.Cantidad + "m");
            
            Console.WriteLine("");
            
            if(m1 == c1)
                Console.WriteLine("Centimetros igual a Metros");
            else
                Console.WriteLine("Centimetros Distinto a Metros");

            if(m1 <= c1)
                Console.WriteLine("Metros Menor o Igual a Centimetros");
            else
                Console.WriteLine("Metros Mayor o Igual a Centimetros");


            Console.ReadKey();
        }
    }
}
