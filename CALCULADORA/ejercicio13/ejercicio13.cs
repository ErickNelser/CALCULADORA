using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio13
{
    public class ejercicio13
    {
        public static void Main() {

            const int meta = 300;
            int acumulado = 0;
            int periodo = 0;
            int pendiente=0;
        
            while (acumulado < meta) {

                Console.WriteLine("Ingrese un numero");
                int numero = int.Parse(Console.ReadLine());
                periodo++;
                acumulado += numero;
                if (numero ==0) {
                    Console.WriteLine("periodod improductivo");
                
                
                }else {
                    Console.WriteLine("Periodo registrado");
                }
                pendiente = meta - acumulado;
                Console.WriteLine("El saldo pendiente es:" + pendiente);

            }
            Console.WriteLine("Los periodo transcurridos fueron:"  + periodo);
        
        
        
        }
    }
}
