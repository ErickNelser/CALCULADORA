using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace CALCULADORA.ejercicio4
{
    public class ejercicio4
    {
        public static void Main() {

            int opcion;
            const string opcion1 = "Ver el registro de expedientes de campana";
            const string opcion2= "Ver la meta del periodo";
            const string opcion3 = "Ver el rango valido de expedientes de excombatientes procesados";
            const string opcion4 = "Salir";
            

            do {
                Console.WriteLine("========================================================================");
                Console.WriteLine("Menu militar");
                Console.WriteLine("========================================================================");
                Console.WriteLine("1)" +opcion1);
                Console.WriteLine("2)" + opcion2);
                Console.WriteLine("3)" + opcion3);
                Console.WriteLine("4)"+ opcion4);
                Console.WriteLine("=======================================================================");
                Console.WriteLine("Elijia la opcion de salir del menu por favor:");
                opcion=int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("NO contamos con menu por ahora");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("NO contamos con la meta exacta");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("NO contamos con el exepediente");

                }

                else if (opcion == 4)
                {

                    break;

                }
                else {

                    Console.WriteLine("NO existe esa opcion");
                }



            } while (opcion<=3);
        
        
        }

    }
}
