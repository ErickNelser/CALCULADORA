using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio12
{
    using System;

    public class ejercicio12
    {
        public static void Main()
        {
            int confirmados = 0;
            int pendientes = 0;

            for (int unidad = 1; unidad <= 6; unidad++)
            {
                Console.WriteLine("Unidad Educativa " + unidad);
                Console.Write("Ingrese la cantidad de estudiantes que abandonaron el año: ");
                int abandono = int.Parse(Console.ReadLine());

                if (abandono >= 25)
                {
                    Console.Write("¿Fue verificado en campo? (1 = Sí, 2 = No): ");
                    int verificado = int.Parse(Console.ReadLine());

                    if (verificado == 1)
                    {
                        confirmados++;
                        Console.WriteLine("DESERCIÓN CRÍTICA CONFIRMADO");
                    }
                    else if (verificado == 2)
                    {
                        pendientes++;
                        Console.WriteLine("DESERCIÓN CRÍTICA PENDIENTE DE VERIFICACIÓN");
                    }
                    else
                    {
                        Console.WriteLine("Opción de verificación inválida.");
                    }
                }
                else if (abandono >= 10)
                {
                    Console.WriteLine("DESERCIÓN MEDIA");
                }
                else
                {
                    Console.WriteLine("DESERCIÓN BAJA");
                }
            }

            Console.WriteLine("RESUMEN");
            Console.WriteLine("Casos críticos confirmados: " + confirmados);
            Console.WriteLine("Casos críticos pendientes: " + pendientes);
        }
    }
}
