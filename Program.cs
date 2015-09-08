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
            Metro m1 = new Metro(10);
            Centimetro c1 = new Centimetro(10);

            m1 = m1 - c1;

            Console.WriteLine(m1.Cantidad);

            Console.ReadKey();
        }
    }
}
