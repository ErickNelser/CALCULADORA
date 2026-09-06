using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio3
{
    public class ejercio3
    {
        public static void Main() { 
        
            const int limiteminimo = 1;
            const int limitemaximo = 200;
            int numeroacta;
            do
            {
                Console.WriteLine("Ingrese un numero de acta de (1 a 200)");
                numeroacta = int.Parse(Console.ReadLine());
                if (numeroacta <= limitemaximo && numeroacta >= limiteminimo)
                {

                    Console.WriteLine("Acta valida");
                }
                else {

                    Console.WriteLine("Acta invalida");



                }



            } while (numeroacta>limitemaximo || numeroacta < limiteminimo);
        }   

    }
}
