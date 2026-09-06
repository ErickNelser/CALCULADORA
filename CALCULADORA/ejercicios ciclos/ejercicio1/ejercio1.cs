using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicios_ciclos.ejercicio1
{
    public class ejercio1
    {
        public static void Main(){
            const int total_telecentros = 8;
            int numero = 1;
            while (numero <= total_telecentros) {
                Console.WriteLine("Registro exitoso:" + numero);
                numero ++;
            
            }
            Console.WriteLine("El numero total de registros fue: " + total_telecentros);
        
        }

    }
}
