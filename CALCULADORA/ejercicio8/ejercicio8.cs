using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio8
{
    public class ejercicio8
    {
        public static void Main() {

            int contador = 1;
            int pares = 0;
            int impares = 0;
            while (contador <= 4) { 
            
                Console.WriteLine("escriba el numero:");
                int numero= int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {

                    pares++;


                }
                else { 
                
                    impares++;
                
                
                }
             contador++;
            }
            Console.WriteLine("========================================================================");
            Console.WriteLine("Resultados detallados");
            Console.WriteLine("========================================================================");
            Console.WriteLine("los numero pares son:" +pares);
            Console.WriteLine("========================================================================");
            Console.WriteLine("los numero impares son:" + impares);
            Console.WriteLine("========================================================================");








        }

    }
}
