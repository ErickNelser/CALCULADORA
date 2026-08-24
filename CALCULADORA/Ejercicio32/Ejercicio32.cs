using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.Ejercicio32
{
    public class Ejercicio32
    {
        static void Main() {

            int numero;
            Console.WriteLine("Cual es su Numero");
            numero=int.Parse(Console.ReadLine());

            Prueba(numero);
        
        }
        static bool Prueba(int numero) {

            if (numero % 2 == 0)
            {

                Console.WriteLine("Es par");
                return true;
            }
            else {

                Console.WriteLine("Es impar");
                return false;
            }
                   
        }

    }
}
/*namespace CALCULADORA.Ejercicio32
{
    public class Ejercicio32
    {
        static void Main() {

            int numero;
            Console.WriteLine("Cual es su Numero");
            numero=int.Parse(Console.ReadLine());
            //Console.WriteLine("el numero que me dio es:" + ((numero % 2 == 0) ? " SI " : "NO"));
            
            bool res = Prueba(numero);
            Console.WriteLine("el numero que me dio es:" + (res?" SI ":"NO") );
            


        }
        static bool Prueba(int numero) {

            if (numero % 2 == 0)
            {

                Console.WriteLine("Es par");
                return true;
            }
            else {

                Console.WriteLine("Es impar");
                return false;
            }
                   
        }

    }
}*/

