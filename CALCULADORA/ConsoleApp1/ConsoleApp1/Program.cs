using System;

namespace JuegodelCalamar
{
    class Program
    {
        static void Main(string[] args)
        {
            const string NOMBRE_JUEGO = "EL JUEGO DEL CALAMAR";
            const int TOTAL_CUPOS = 3;
            const int EDAD_MINIMA = 18;
            const double PREMIO_TOTAL = 45600000000;
            const string PRUEBA_1 = "Luz roja, luz verde";
            const string PRUEBA_2 = "Dalgona (galleta de azucar)";
            const string PRUEBA_3 = "Tira y afloja";
            const string ESTADO_VIVO = "SOBREVIVE";
            const string ESTADO_FUERA = "ELIMINADO";

            string jugador1 = "";
            string jugador2 = "";
            string jugador3 = "";
            string jugadorElegido = "";
            string estadoFinal = "";
            string pruebaElegida = "";
            string clasificacion = "";

            int numeroJugador = 0;
            int opcionJugador = 0;
            int opcionPrueba = 0;
            int decision = 0;
            int edad = 0;
            int puntaje = 0;

            Console.WriteLine("============================");
            Console.WriteLine("   " + NOMBRE_JUEGO);
            Console.WriteLine("   UNICEN - Programacion II");
            Console.WriteLine("============================");
            Console.WriteLine("Premio acumulado : " + PREMIO_TOTAL + " wones");
            Console.WriteLine("Cupos habilitados: " + TOTAL_CUPOS);
            Console.WriteLine("Edad minima      : " + EDAD_MINIMA + " anios");
            Console.WriteLine();

            Console.WriteLine("REGISTRO DE JUGADORES");
            Console.Write("Nombre del jugador 1: ");
            jugador1 = Console.ReadLine();
            Console.Write("Nombre del jugador 2: ");
            jugador2 = Console.ReadLine();
            Console.Write("Nombre del jugador 3: ");
            jugador3 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Jugadores inscritos:");
            Console.WriteLine("  001 - " + jugador1);
            Console.WriteLine("  002 - " + jugador2);
            Console.WriteLine("  003 - " + jugador3);
            Console.WriteLine();

            Console.WriteLine("--- SELECCION DE JUGADOR ---");
            Console.WriteLine("1) " + jugador1);
            Console.WriteLine("2) " + jugador2);
            Console.WriteLine("3) " + jugador3);
            Console.Write("Que jugador entra a la arena (1-3): ");
            opcionJugador = int.Parse(Console.ReadLine());

            if (opcionJugador == 1)
            {
                numeroJugador = 1;
                jugadorElegido = jugador1;
            }
            else if (opcionJugador == 2)
            {
                numeroJugador = 2;
                jugadorElegido = jugador2;
            }
            else if (opcionJugador == 3)
            {
                numeroJugador = 3;
                jugadorElegido = jugador3;
            }
            else
            {
                numeroJugador = 0;
                jugadorElegido = "SIN JUGADOR";
                estadoFinal = ESTADO_FUERA;
                Console.WriteLine("Opcion invalida de jugador.");
            }

            if (numeroJugador != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Jugador seleccionado: 00" + numeroJugador + " - " + jugadorElegido);
                Console.Write("Ingrese la edad de " + jugadorElegido + ": ");
                edad = int.Parse(Console.ReadLine());

                if (edad >= EDAD_MINIMA)
                {
                    Console.WriteLine("ACCESO PERMITIDO. " + jugadorElegido + " puede competir.");
                    puntaje = puntaje + 20;
                }
                else
                {
                    Console.WriteLine("ACCESO DENEGADO. No cumple con la edad minima.");
                    estadoFinal = ESTADO_FUERA;
                }
            }

            if (numeroJugador != 0)
            {
                if (estadoFinal != ESTADO_FUERA)
                {
                    Console.WriteLine();
                    Console.WriteLine("--- SELECCION DE PRUEBA ---");
                    Console.WriteLine("1) " + PRUEBA_1);
                    Console.WriteLine("2) " + PRUEBA_2);
                    Console.WriteLine("3) " + PRUEBA_3);
                    Console.Write("Elija la prueba (1-3): ");
                    opcionPrueba = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (opcionPrueba == 1)
                    {
                        pruebaElegida = PRUEBA_1;
                        Console.WriteLine("PRUEBA: " + PRUEBA_1);
                        Console.WriteLine("La muñeca gigante gira la cabeza:");
                        Console.WriteLine("1) Seguir corriendo");
                        Console.WriteLine("2) Quedarse inmovil");
                        Console.WriteLine("3) Esconderse detras de otro");
                        Console.Write("Accion tomada por " + jugadorElegido + ": ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            Console.WriteLine("El jugador fue detectado en movimiento.");
                            estadoFinal = ESTADO_FUERA;
                        }
                        else if (decision == 2)
                        {
                            Console.WriteLine("El jugador permanecio totalmente quieto. Sobrevive a la primera prueba!");
                            puntaje = puntaje + 70;
                            estadoFinal = ESTADO_VIVO;
                        }
                        else if (decision == 3)
                        {
                            Console.WriteLine("El jugador logra cubrirse y no es visto.");
                            puntaje = puntaje + 40;
                            estadoFinal = ESTADO_VIVO;
                        }
                        else
                        {
                            Console.WriteLine("Respuesta invalida.");
                            estadoFinal = ESTADO_FUERA;
                        }
                    }
                    else if (opcionPrueba == 2)
                    {
                        pruebaElegida = PRUEBA_2;
                        Console.WriteLine("PRUEBA: " + PRUEBA_2);
                        Console.WriteLine("Elija la figura de la galleta:");
                        Console.WriteLine("1) Triangulo   (facil)");
                        Console.WriteLine("2) Estrella    (medio)");
                        Console.WriteLine("3) Sombrilla   (dificil)");
                        Console.Write("Figura elegida por " + jugadorElegido + ": ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            Console.WriteLine("El triangulo es facil de cortar. " + jugadorElegido + " lo logra sin problemas!");
                            puntaje = puntaje + 50;
                            estadoFinal = ESTADO_VIVO;
                        }
                        else if (decision == 2)
                        {
                            Console.WriteLine("La estrella tiene varias puntas peligrosas.");
                            Console.Write("Lame la galleta para derretir el azucar? (1 = si / 2 = no): ");
                            int decisionAnidada = int.Parse(Console.ReadLine());

                            if (decisionAnidada == 1)
                            {
                                Console.WriteLine("El calor de la saliva disuelve los bordes! " + jugadorElegido + " logra extraer la figura.");
                                puntaje = puntaje + 65;
                                estadoFinal = ESTADO_VIVO;
                            }
                            else
                            {
                                Console.WriteLine("La galleta se rompe al intentar separarla.");
                                estadoFinal = ESTADO_FUERA;
                            }
                        }
                        else if (decision == 3)
                        {
                            Console.WriteLine("La sombrilla es la figura mas dificil del juego.");
                            Console.Write("Usa la aguja calentada con el encendedor? (1 = si / 2 = no): ");
                            int decisionAnidada = int.Parse(Console.ReadLine());

                            if (decisionAnidada == 1)
                            {
                                Console.WriteLine("La aguja caliente corta el azucar. " + jugadorElegido + " lo logra!");
                                puntaje = puntaje + 80;
                                estadoFinal = ESTADO_VIVO;
                            }
                            else
                            {
                                Console.WriteLine("La figura es demasiado compleja y se fractura por completo.");
                                estadoFinal = ESTADO_FUERA;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Figura inexistente.");
                            estadoFinal = ESTADO_FUERA;
                        }
                    }
                    else if (opcionPrueba == 3)
                    {
                        pruebaElegida = PRUEBA_3;
                        Console.WriteLine("PRUEBA: " + PRUEBA_3);
                        Console.WriteLine("Elija la estrategia del equipo sobre el puente:");
                        Console.WriteLine("1) Jalar con toda la fuerza");
                        Console.WriteLine("2) Inclinarse hacia atras");
                        Console.WriteLine("3) Soltar la cuerda");
                        Console.Write("Estrategia elegida por " + jugadorElegido + ": ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            Console.WriteLine("El equipo rival tenia mas fuerza. Son arrastrados al vacio.");
                            estadoFinal = ESTADO_FUERA;
                        }
                        else if (decision == 2)
                        {
                            Console.WriteLine("La tecnica de palanca desestabiliza al rival! El equipo gana.");
                            puntaje = puntaje + 75;
                            estadoFinal = ESTADO_VIVO;
                        }
                        else if (decision == 3)
                        {
                            Console.WriteLine("Soltar la cuerda hizo caer al equipo entero.");
                            estadoFinal = ESTADO_FUERA;
                        }
                        else
                        {
                            Console.WriteLine("Sin estrategia valida.");
                            estadoFinal = ESTADO_FUERA;
                        }
                    }
                    else
                    {
                        pruebaElegida = "NINGUNA";
                        Console.WriteLine("Esa prueba no existe.");
                        estadoFinal = ESTADO_FUERA;
                    }
                }
            }

            if (puntaje >= 90)
            {
                clasificacion = "FINALISTA";
            }
            else if (puntaje >= 60)
            {
                clasificacion = "AVANZA A LA SIGUIENTE RONDA";
            }
            else if (puntaje >= 30)
            {
                clasificacion = "PASA CON OBSERVACIONES";
            }
            else
            {
                clasificacion = "FUERA DE COMPETENCIA";
            }

            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("   REPORTE FINAL - " + NOMBRE_JUEGO);
            Console.WriteLine("==================================================");
            Console.WriteLine("Jugador        : " + jugadorElegido);
            Console.WriteLine("Numero         : 00" + numeroJugador);
            Console.WriteLine("Prueba         : " + (pruebaElegida == "" ? "Ninguna" : pruebaElegida));
            Console.WriteLine("Estado         : " + estadoFinal);
            Console.WriteLine("Puntaje        : " + puntaje + " / 100");
            Console.WriteLine("Clasificacion  : " + clasificacion);

            if (estadoFinal == ESTADO_VIVO)
            {
                Console.WriteLine("Premio en juego: " + PREMIO_TOTAL + " wones");
            }

            Console.WriteLine("==================================================");

            Console.ReadLine();
        }
    }
}