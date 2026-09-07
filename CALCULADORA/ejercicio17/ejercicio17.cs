using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio17
{
    public class ejercicio17
    {
        public static void Main()
        {
            int contador = 0;
            int suma = 0;

            Console.Write("Ingrese el tiempo del trámite en minutos (-1 para terminar): ");
            int minutos = int.Parse(Console.ReadLine());

            while (minutos != -1)
            {
                contador++;
                suma += minutos;

                Console.Write("Ingrese el tiempo del trámite en minutos (-1 para terminar): ");
                minutos = int.Parse(Console.ReadLine());
            }

            if (contador > 0)
            {
                double promedio = (double)suma / contador;

                Console.WriteLine("RESULTADOS");
                Console.WriteLine("Trámites registrados: " + contador);
                Console.WriteLine("Suma de minutos: " + suma);
                Console.WriteLine("Promedio: " + promedio);

                if (promedio >= 45)
                {
                    Console.WriteLine("Clasificación: Atención lenta.");
                }
                else if (promedio >= 20)
                {
                    Console.WriteLine("Clasificación: Atención regular.");
                }
                else
                {
                    Console.WriteLine("Clasificación: Atención rápida.");
                }
            }
            else
            {
                Console.WriteLine("No hubo datos registrados.");
            }
        }
    }
}
