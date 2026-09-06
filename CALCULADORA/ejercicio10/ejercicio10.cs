using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio10
{
    public class ejercicio10
    {
        public static void Main() {

            const int umbral = 8;
            int suma = 0;
            double promedio = 0;
            int contador = 1;
            while (contador <= 8) {
                Console.WriteLine("Ingrese el numero:");
                int numero = int.Parse(Console.ReadLine());
                suma += numero;
                contador ++;          
            
            }
            promedio = suma / 8;
            if (promedio == 8)
            {

                Console.WriteLine("mercurio normal");

            }
            else {

                Console.WriteLine("mercurio peligroso");

            }
        
        
        }

    }
}
