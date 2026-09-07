using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio19
{
    public class ejercicio19
    {
        public static void Main()
        {
            int recursos = 3;
            int puntos = 0;
            int opcion;

            do
            {
                Console.WriteLine("Campaña ENDE - San Matías");
                Console.WriteLine("Recursos: " + recursos);
                Console.WriteLine("Puntos: " + puntos);
                Console.WriteLine("1. Intervención intensiva");
                Console.WriteLine("2. Intervención preventiva");
                Console.WriteLine("3. Retirarse");
                Console.Write("Elija una estrategia: ");

                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    puntos += 200;
                    recursos--;

                    Console.WriteLine("Intervención intensiva realizada.");

                 
                    if (recursos == 1)
                    {
                        Console.WriteLine("¡Atención! Solo queda un recurso.");
                    }
                }
                else if (opcion == 2)
                {
                    puntos += 100;
                    Console.WriteLine("Intervención preventiva realizada.");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("La brigada decidió retirarse.");
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                }

            } while (recursos > 0 && opcion != 3 && puntos < 5000);

            Console.WriteLine("RESULTADOS");
            Console.WriteLine("Puntos obtenidos: " + puntos);
            Console.WriteLine("Recursos restantes: " + recursos);

            if (puntos >= 5000)
            {
                Console.WriteLine("Clasificación: GENERACIÓN ALTA");
            }
            else if (puntos >= 2000)
            {
                Console.WriteLine("Clasificación: GENERACIÓN MEDIA");
            }
            else
            {
                Console.WriteLine("Clasificación: GENERACIÓN BAJA");
            }
        }
    }
}
