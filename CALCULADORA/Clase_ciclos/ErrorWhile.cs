using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.Clase_ciclos
{
    internal class ErrorWhile
    {
        public static void Main()
        {

            int vida = 0;
            
            while (vida > 0)
            {
                Console.WriteLine("Se estan acabando las vidas " + vida);
                vida--;
            }
            Console.WriteLine("Fin");

        }
    }
}