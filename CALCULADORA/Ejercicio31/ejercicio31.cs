using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.Ejercicio31
{
    public class ejercicio31
    {
        static void Main() {
            string nombre = PedirNombre();
            Console.WriteLine("Hola " + nombre + ", bienvenido a C#");
        
        
        }
        static string PedirNombre() {
            Console.WriteLine("ingrese su nombre");
            return Console.ReadLine();
        }

    }
}
