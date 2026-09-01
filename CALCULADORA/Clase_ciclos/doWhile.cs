using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.Clase_ciclos
{
    public class doWhile
    {
        public static void Main() {
            int opcion;
            do
            {
                Console.WriteLine("1. Inicio");
                Console.WriteLine("2. Salir");
                Console.WriteLine("opcion");
                opcion = int.Parse(Console.ReadLine());
            }
            while (opcion !=2);

            Console.WriteLine("Fin del juego");
        
        }
    }
}
