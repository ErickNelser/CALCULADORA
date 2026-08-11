using System;

namespace programacion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bienvenido a clase 2 de funcinoes y metodos");

            Console.WriteLine("Por favor dinos tu nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Bienvenido " + nombre);

            
            Console.WriteLine("por favor dinos en que semestre estas");
            string semestre = Console.ReadLine();

            
            Console.WriteLine("Vamos a interactuar contigo y realizar funciones y metodos");

            
            Console.WriteLine("por favor ingresa un numero para A");
            int a = int.Parse(Console.ReadLine());

            
            Console.WriteLine("por favor ingresa un numero para B");
            int b = int.Parse(Console.ReadLine());

            
            int suma = a + b;
            int multiplicacion = a * b;
            int resta = a - b;

            Console.WriteLine("La suma es " + suma);
            Console.WriteLine("La multiplicacion es " + multiplicacion);
            Console.WriteLine("La resta es " + resta);
        }
    }
}


