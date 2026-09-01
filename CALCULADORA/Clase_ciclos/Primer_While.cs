using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace CALCULADORA.Clase_ciclos
{
    public class Primer_While
    {
        public static void Main()
        {

            int num = 0;
            Console.WriteLine("El numero es;" + num);
            while (num <= 5)
            {
                Console.WriteLine("El numero se actualizo:" + num );
                num++;
            }
        }
    }
}
