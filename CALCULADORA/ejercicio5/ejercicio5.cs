using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio5
{
    public class ejercicio5
    {
        public static void Main() {
            const int umbral = 1800;
            int cumple = 0;
            int nocumple= 0;
            for (int i = 1; i < 4; i++)
            {

                Console.WriteLine("indique su pieza");
                int pieza = int.Parse(Console.ReadLine());
                if (pieza >= umbral)
                {
                    Console.WriteLine("Si cumplio:");
                    cumple++;
                }
                else
                {
                    Console.WriteLine("NO cumplio:");
                    nocumple++;
                }
            }
            Console.WriteLine("========================================================================");
            Console.WriteLine("Resultados detallados");
            Console.WriteLine("========================================================================");
            Console.WriteLine("Si cumplieron" + cumple);
            Console.WriteLine("========================================================================");
            Console.WriteLine("NO cumplieron" + nocumple);
            Console.WriteLine("========================================================================");













        }

    }
}
