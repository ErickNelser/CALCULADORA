using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.JuegoDelCalamar
{
    public class JuegoDelCalamar
    {
        static void Main() {

            const int edadminima = 18;
            const string nombrejuego = "JUEGO DEL CALAMAR";
            const double premiototal  = 45600000000;
            const int cupohabilitado = 3;
            const string prueba1 = "Luz roja,luz verde";
            const string prueba2 = "Dalgona";
            const string prueba3 = "Tira y afloja";
            const string estadovivo = "SOBREVIVE";
            const string estadofuera = "ELIMINADO";

            int edad;
            int opcion;
            int puntuacion;
            string jugador1;
            string jugador2;
            string jugador3;
            int numerojugador;
            int decision;
            int jugadorelegido;
            int figura;
            int aguja;
            
            
            Console.WriteLine("=========================");
            Console.WriteLine(nombrejuego);
            Console.WriteLine("=======================");
            Console.Write("El premio total es:" + premiototal);
            Console.Write("Cupos habilitados es:" + cupohabilitado);
            Console.WriteLine("La edad minima es:" + edadminima + "años");
            Console.WriteLine("=======================");

            Console.WriteLine("REGISTRO DE JUGADORES");
            Console.Write("Nombre del jugador 1: ");
            jugador1 = Console.ReadLine();
            Console.Write("Nombre del jugador 2: ");
            jugador2 = Console.ReadLine(); 
            Console.Write("Nombre del jugador 3: ");
            jugador3 = Console.ReadLine();
            Console.WriteLine("JUGADORES INSCRITOS");
            Console.WriteLine("001- " + jugador1);
            Console.WriteLine("002-" + jugador2);
            Console.WriteLine("003-" + jugador3);
            Console.WriteLine("SELECCION DE JUGADOR");
            Console.WriteLine("1) " + jugador1);
            Console.WriteLine("2) " + jugador2);
            Console.WriteLine("3) " + jugador3);
            Console.WriteLine("Que jugador entra a la arena:");
            jugadorelegido = int.Parse(Console.ReadLine());

            if (jugadorelegido == 1)
            {
                Console.Write("Jugador seleccionado: " + jugador1);

                Console.Write("Ingrese la edad de " + jugador1 + ": ");
                edad = int.Parse(Console.ReadLine());

                if (edad >= edadminima)
                {
                    Console.WriteLine("ACCESO PERMITIDO. " + jugador1 + " puede competir.");
                }
                else
                {
                    Console.WriteLine("ACCESO DENEGADO. " + jugador1 + " no puede competir.");
                }
            }
            else if (jugadorelegido == 2)
            {
                Console.Write("Jugador seleccionado: " + jugador2  );

                Console.Write("Ingrese la edad de " + jugador2 + ": ");
                edad = int.Parse(Console.ReadLine());

                if (edad >= edadminima)
                {
                    Console.WriteLine("ACCESO PERMITIDO. " + jugador2 + " puede competir.");
                }
                else
                {
                    Console.WriteLine("ACCESO DENEGADO. " + jugador2 + " no puede competir.");
                }
            }
            else if (jugadorelegido == 3)
            {
                Console.Write("Jugador seleccionado: " + jugador3);

                Console.Write("Ingrese la edad de " + jugador3 + ": ");
                edad = int.Parse(Console.ReadLine());

                if (edad >= edadminima)
                {
                    Console.WriteLine("ACCESO PERMITIDO. " + jugador3 + " puede competir.");
                }
                else
                {
                    Console.WriteLine("ACCESO DENEGADO. " + jugador3 + " no puede competir.");
             
                }



            }
            Console.WriteLine("Seleccion de prueba");
            Console.Write("1)" + prueba1);
            Console.Write("2)" + prueba2);
            Console.Write("3)" + prueba3);
            Console.Write("Elija la rueba del (1-3):");
            decision = int.Parse(Console.ReadLine());

            if (decision == 1)
            {
                Console.WriteLine("PRUEBA: Luz roja, luz verde");
            }
            else if (decision == 2)
            {
                Console.WriteLine("PRUEBA: Dalgona (galleta de azucar)");

                Console.WriteLine("Elija la figura de la galleta:");
                Console.WriteLine("1) Triangulo (facil)");
                Console.WriteLine("2) Estrella (medio)");
                Console.WriteLine("3) Sombrilla (dificil)");

                Console.Write("Figura elegida por: " + jugadorelegido);
                figura = int.Parse(Console.ReadLine());

                if (figura == 1)
                {
                    Console.WriteLine("El triangulo es la figura mas facil del juego.");
                    Console.Write("Usa la aguja calentada con el encendedor? (1 = si / 2 = no): ");
                    aguja = int.Parse(Console.ReadLine());

                    if (aguja == 1)
                    {
                        Console.WriteLine("La aguja caliente corta el azucar. lo logra!");
                    }
                    else
                    {
                        Console.WriteLine("no usa la aguja caliente y falla.");
                    }
                }
                else if (figura == 2)
                {
                    Console.WriteLine("La estrella tiene dificultad media.");
                    Console.Write("Usa la aguja calentada con el encendedor? (1 = si / 2 = no): ");
                    aguja = int.Parse(Console.ReadLine());

                    if (aguja == 1)
                    {
                        Console.WriteLine("La aguja caliente corta el azucar.lo logra!");
                    }
                    else
                    {
                        Console.WriteLine("no usa la aguja caliente y falla.");
                    }
                }
                else if (figura == 3)
                {
                    Console.WriteLine("La sombrilla es la figura mas dificil del juego.");

                    Console.Write("Usa la aguja calentada con el encendedor? (1 = si / 2 = no): ");
                    aguja = int.Parse(Console.ReadLine());

                    if (aguja == 1)
                    {
                        Console.WriteLine("La aguja caliente corta el azucar.lo logra!");
                    }
                    else
                    {
                        Console.WriteLine("No usa la aguja caliente y falla.");
                    }
                }
            }
            else if (decision == 3)
            {
                Console.WriteLine("PRUEBA: Tira y afloja");
            }






        }




    }
}
