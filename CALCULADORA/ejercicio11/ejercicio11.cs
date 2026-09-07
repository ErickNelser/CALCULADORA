using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio11
{
    using System;

    public class ejercicio11
    {
        public static void Main()
        {
            int opcion;
            int urgentes = 0;
            const int Meta = 50;

            do
            {
                Console.WriteLine(" Instituto de Hidráulica e Hidrología UMSA ");
                Console.WriteLine("1. Registrar medición");
                Console.WriteLine("2. Consultar meta");
                Console.WriteLine("3. Salir");
                Console.Write("Elija una opción: ");

                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Seleccione la zona:");
                    Console.WriteLine("1. Zona Norte");
                    Console.WriteLine("2. Zona Sur");
                    Console.Write("Opción: ");

                    int zona = int.Parse(Console.ReadLine());

                    if (zona == 1)
                    {
                        Console.WriteLine("¿El registro es urgente?");
                        Console.WriteLine("1. Sí");
                        Console.WriteLine("2. No");
                        Console.Write("Opción: ");

                        int urgente = int.Parse(Console.ReadLine());

                        if (urgente == 1)
                        {
                            urgentes++;
                            Console.WriteLine("Medición registrada en Zona Norte (URGENTE).");
                        }
                        else if (urgente == 2)
                        {
                            Console.WriteLine("Medición registrada en Zona Norte.");
                        }
                        else
                        {
                            Console.WriteLine("Opción de urgencia inválida.");
                        }
                    }
                    else if (zona == 2)
                    {
                        Console.WriteLine("¿El registro es urgente?");
                        Console.WriteLine("1. Sí");
                        Console.WriteLine("2. No");
                        Console.Write("Opción: ");

                        int urgente = int.Parse(Console.ReadLine());

                        if (urgente == 1)
                        {
                            urgentes++;
                            Console.WriteLine("Medición registrada en Zona Sur (URGENTE).");
                        }
                        else if (urgente == 2)
                        {
                            Console.WriteLine("Medición registrada en Zona Sur.");
                        }
                        else
                        {
                            Console.WriteLine("Opción de urgencia inválida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Zona inválida.");
                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("La meta del período es de " + Meta + " mediciones.");
                }
                else if (opcion != 3)
                {
                    Console.WriteLine("Opción inválida.");
                }

            } while (opcion != 3);

            Console.WriteLine("\nPrograma finalizado.");
            Console.WriteLine("Total de registros urgentes: " + urgentes);
        }
    }
}
