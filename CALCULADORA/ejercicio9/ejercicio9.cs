using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio9
{
    public class ejercicio9
    {
        public static void Main() {

            int maximo = 0;
            int minimo = 0;
            int avmaximo = 0;
            int avminimo = 0;
            for (int i = 1; i < 6; i++) {
                Console.WriteLine("ingrese el numero:");
                int numero = int.Parse(Console.ReadLine());
                if (i == 1) {
                    maximo = numero;
                    minimo = numero;
                    avmaximo = i;
                    avminimo = i;
                }
                if (numero > maximo)
                {

                    maximo = numero;
                    avminimo = i;

                }
                else if (numero < minimo) { 
                
                    minimo = numero;
                    avminimo = i;
                
                
                }
            
            
            
            }
            Console.WriteLine("========================================================================");
            Console.WriteLine("Resultados detallados");
            Console.WriteLine("========================================================================");
            Console.WriteLine("El ultimo mayo fue:" + maximo  + "y su posicion es:" + avmaximo );
            Console.WriteLine("========================================================================");
            Console.WriteLine("El ultimo menor fue:" + minimo + "y su posicion es:" + avminimo);
            Console.WriteLine("========================================================================");



        }

    }
}
