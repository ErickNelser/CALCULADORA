using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicios_ciclos.ejercicio2
{
    public  class ejercicio2
    {
        public static void Main() {
            int suma = 0 ;
            const int meta= 3000;
            int contador = 1;
            while (contador <= 4) {
                Console.WriteLine("ponga el valor de sus piezas");
                int piezas = int.Parse(Console.ReadLine());
                contador++;
                suma += piezas;
            }
            if (suma >= meta)
            {
                Console.WriteLine("Meta conseguida");


            }
            else
            {

                Console.WriteLine("meta no conseguida");
            }
        }
    }
}

