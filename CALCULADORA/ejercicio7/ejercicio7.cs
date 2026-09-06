using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CALCULADORA.ejercicio7
{
    public class ejercicio7
    {
        public static void Main() {

            const int totalsurtidores = 8;
            int contadorlleno = 0;
            int contadorvacio = 0;
            int contadorparcial = 0;
            for (int i = 0; i < totalsurtidores; i++) {

                Console.WriteLine("Cuantos son los litros despachados:");
                int litros = int.Parse(Console.ReadLine());
                if (litros >= 15000)
                {

                    contadorlleno++;
                }
                else if (litros == 8000)
                {

                    contadorparcial++;


                }
                else { 
                
                    contadorvacio++;
                }
       

            }

            Console.WriteLine("========================================================================");
            Console.WriteLine("Resultados detallados");
            Console.WriteLine("========================================================================");
            Console.WriteLine("los surtidores llenos son:" + contadorlleno);
            Console.WriteLine("========================================================================");
            Console.WriteLine("los surtidores parciales son:" + contadorparcial);
            Console.WriteLine("========================================================================");
            Console.WriteLine("los surtidores vacios son:" + contadorvacio);
            Console.WriteLine("========================================================================");

        }




    }
}
