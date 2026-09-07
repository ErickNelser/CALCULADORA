using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio20
{
    internal class ejercicio20
    {
        public static void Main()
        {
            const int TOTAL_HORAS = 4;
            const int MIN_INCIDENTES = 0;
            const int MAX_INCIDENTES = 500;
            const int ENTREGA = 80;
            const double UMBRAL_CRITICO = 300;
            const double UMBRAL_ALTO = 150;

            int opcion;
            int totalIncidentes = 0;
            double promedio = 0;
            bool datosCargados = false;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Carga de incidentes de seguridad");
                Console.WriteLine("2. Reporte de clasificacion");
                Console.WriteLine("3. Simulacion de cobertura");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    totalIncidentes = 0;

                    for (int i = 1; i <= TOTAL_HORAS; i++)
                    {
                        int incidentes;

                        do
                        {
                            Console.Write("Ingrese los incidentes de la hora " + i + " (0-500): ");
                            incidentes = int.Parse(Console.ReadLine());

                            if (incidentes < MIN_INCIDENTES || incidentes > MAX_INCIDENTES)
                            {
                                Console.WriteLine("Valor invalido. Intente nuevamente.");
                            }

                        } while (incidentes < MIN_INCIDENTES || incidentes > MAX_INCIDENTES);

                        totalIncidentes += incidentes;
                    }

                    promedio = (double)totalIncidentes / TOTAL_HORAS;
                    datosCargados = true;

                    Console.WriteLine("Datos cargados correctamente.");
                }
                else if (opcion == 2)
                {
                    if (datosCargados)
                    {
                        Console.WriteLine("Promedio: " + promedio);

                        if (promedio >= UMBRAL_CRITICO)
                        {
                            Console.WriteLine("Clasificacion: NIVEL CRITICO");
                        }
                        else if (promedio >= UMBRAL_ALTO)
                        {
                            Console.WriteLine("Clasificacion: NIVEL ALTO");
                        }
                        else
                        {
                            Console.WriteLine("Clasificacion: NIVEL NORMAL");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Primero debe cargar los datos.");
                    }
                }
                else if (opcion == 3)
                {
                    if (datosCargados)
                    {
                        int restante = totalIncidentes;
                        int jornadas = 0;

                        while (restante > 0)
                        {
                            restante -= ENTREGA;
                            jornadas++;
                        }

                        Console.WriteLine("La cobertura alcanza para " + jornadas + " jornadas.");
                    }
                    else
                    {
                        Console.WriteLine("Primero debe cargar los datos.");
                    }
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("RESUMEN DE LA SESION");

                    if (datosCargados)
                    {
                        Console.WriteLine("Total de incidentes: " + totalIncidentes);
                        Console.WriteLine("Promedio: " + promedio);
                    }
                    else
                    {
                        Console.WriteLine("No se cargaron datos.");
                    }

                    Console.WriteLine("Sesion finalizada.");
                }
                else
                {
                    Console.WriteLine("Opcion invalida.");
                }

            } while (opcion != 4);
        }
    }
}
}
