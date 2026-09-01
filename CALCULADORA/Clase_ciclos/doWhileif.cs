using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.Clase_ciclos
{
    public class doWhileif
    {
        public static void Main() {

            int edad;
            do
            {

                Console.WriteLine("Ingrese su edad (1 a 120)");
                edad = int.Parse(Console.ReadLine());
                if (edad < 1 || edad > 120)
                {
                    Console.WriteLine("edad invalida");
                }

            } while (edad < 1 || edad > 120);
            Console.WriteLine("Edad registrada" + edad);



        }

    }
}
