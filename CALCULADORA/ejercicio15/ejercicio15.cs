using System;
using System.Collections.Generic;
using System.Text;

namespace CALCULADORA.ejercicio15
{
    public class ejercicio15
    {         
         public static void Main()
        { 
                const int codigoCorrecto = 2020;
                int intentos = 3;
                bool acceso = false;

                do
                {
                    Console.Write("Ingrese el código de acceso: ");
                    int codigo = int.Parse(Console.ReadLine());

                    if (codigo == codigoCorrecto)
                    {
                        acceso = true;

                        Console.Write("Ingrese el nivel de permiso (1 = consulta, 2 = edición): ");
                        int permiso = int.Parse(Console.ReadLine());

                        if (permiso == 1)
                        {
                            Console.WriteLine("Acceso concedido: Permiso de CONSULTA.");
                        }
                        else if (permiso == 2)
                        {
                            Console.WriteLine("Acceso concedido: Permiso de EDICIÓN.");
                        }
                        else
                        {
                            Console.WriteLine("Nivel de permiso no válido.");
                        }
                    }
                    else
                    {
                        intentos--;
                        Console.WriteLine("Código incorrecto.");

                        if (intentos > 0)
                        {
                            Console.WriteLine("Intentos restantes: " + intentos);
                        }
                    }

                } while (intentos > 0 && acceso == false);

                if (acceso == false)
                {
                    Console.WriteLine("Cuenta bloqueada por agotar los intentos.");
                }
            
        }
    }
    
}
