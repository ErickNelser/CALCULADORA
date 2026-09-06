using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Timers;

namespace CALCULADORA.ejercicio6
{
    public class ejercicio6
    {
        public static void Main() {

            int reserva = 1800;
            int jornada =0 ;
    
            while (reserva > 0) {
                Console.WriteLine("cuantas entregas se realizo:");
                int entregas = int.Parse(Console.ReadLine());
                reserva -= entregas;
                jornada++;
                Console.WriteLine("quedan en reserva:" + reserva);
                if (reserva <= 360) {

                    Console.WriteLine("Alerta se llego al 20% de la reserva");
                
                }
            }
            Console.WriteLine("El total de jornadas total es de:" + jornada);
        
        }


    }
}
