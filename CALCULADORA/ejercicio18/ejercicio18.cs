using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio18
{
    public class ejercicio18
    {
        public static void Main()
        {
            int totalLotes = 0;
            int hitosConmemorados = 0;

            int numeroSerie = 1;

            for (int anio = 2019; anio <= 2027; anio++)
            {
                Console.WriteLine("Año: " + anio);
                Console.Write("Ingrese la cantidad de lotes producidos: ");
                int lotes = int.Parse(Console.ReadLine());

                totalLotes += lotes;

                if (numeroSerie % 5 == 0)
                {
                    Console.Write("¿Hubo acto conmemorativo? (1 = Sí, 2 = No): ");
                    int respuesta = int.Parse(Console.ReadLine());

                    if (respuesta == 1)
                    {
                        Console.WriteLine("Se realizó el acto conmemorativo.");
                        hitosConmemorados++;
                    }
                    else
                    {
                        Console.WriteLine("No hubo acto conmemorativo.");
                    }
                }

                Console.WriteLine();
                numeroSerie++;
            }

            Console.WriteLine("RESULTADOS");
            Console.WriteLine("Total de lotes de producción: " + totalLotes);
            Console.WriteLine("Hitos conmemorados: " + hitosConmemorados);
        }
    }
}
