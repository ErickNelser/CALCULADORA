using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio16
{
    public class ejercicio16
    {
        public static void Main()
        {
            const int totalCursos = 8;
            double incentivo;
            double incentivoTotal = 0;
            int observaciones = 0;

            for (int i = 1; i <= totalCursos; i++)
            {
                Console.WriteLine("Curso " + i);
                Console.Write("Ingrese la cantidad de estudiantes: ");
                double estudiantes = double.Parse(Console.ReadLine());

                if (estudiantes >= 70)
                {
                    incentivo = estudiantes * 0.20;
                    Console.WriteLine("Incentivo del 20%: " + incentivo);
                }
                else if (estudiantes >= 30)
                {
                    incentivo = estudiantes * 0.10;
                    Console.WriteLine("Incentivo del 10%: " + incentivo);
                }
                else
                {
                    incentivo = 0;
                    observaciones++;
                    Console.WriteLine("Sin incentivo. Se registra una observación.");
                }

                incentivoTotal += incentivo;
                Console.WriteLine();
            }

            Console.WriteLine("RESULTADOS");
            Console.WriteLine("Incentivo total del periodo: " + incentivoTotal);
            Console.WriteLine("Cantidad de observaciones: " + observaciones);
        }
    }
}
