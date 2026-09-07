using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace CALCULADORA.ejercicio14
{
    public class ejercicio14
    {
        public static void Main()
        {
            int totalGeneral = 0;
            const int umbral = 60;

       
            for (int zona = 1; zona <= 4; zona++)
            {
                int subtotalZona = 0; 

                Console.WriteLine("Zona " + zona + " ");

             
                for (int dia = 1; dia <= 3; dia++)
                {
                    Console.Write("Ingrese los contratados del día " + dia + ": ");
                    int contratados = int.Parse(Console.ReadLine());

                    subtotalZona += contratados;
                }

             
                Console.WriteLine("Subtotal de la zona " + zona + ": " + subtotalZona);

                if (subtotalZona > umbral)
                {
                    Console.WriteLine("INSERCION ALTA");
                }
                else
                {
                    Console.WriteLine("INSERCION BAJA");
                }

            
                totalGeneral += subtotalZona;
            }

            Console.WriteLine("================================");
            Console.WriteLine("Total general de El Alto: " + totalGeneral);
        }
    }












}
