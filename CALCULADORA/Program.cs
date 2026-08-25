using System;

namespace JuegoDelCalamar
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------- 1. CONSTANTES ----------
            const string NOMBRE_JUEGO   = "EL JUEGO DEL CALAMAR";
            const int    TOTAL_CUPOS    = 3;
            const int    EDAD_MINIMA    = 18;
            const double PREMIO_TOTAL   = 45600000000;
            const string PRUEBA_1       = "Luz roja, luz verde";
            const string PRUEBA_2       = "Dalgona";
            const string PRUEBA_3       = "Tira y afloja";
            const string ESTADO_VIVO    = "SOBREVIVE";
            const string ESTADO_FUERA   = "ELIMINADO";

            // ---------- 2. VARIABLES ----------
            string jugador1;
            string jugador2;
            string jugador3;
            string jugadorElegido = "";
            string estadoFinal    = "";
            string pruebaElegida  = "Ninguna";
            string clasificacion  = "";
            int    numeroJugador  = 0;
            int    puntaje        = 0;
            int    opcionJugador;
            int    opcionPrueba;
            int    decision;
            int    edad;

            // ---------- 3. PORTADA ----------
            Console.WriteLine("====================================================");
            Console.WriteLine("   " + NOMBRE_JUEGO);
            Console.WriteLine("   UNICEN - Programacion II");
            Console.WriteLine("====================================================");
            Console.WriteLine("Premio acumulado : " + PREMIO_TOTAL + " wones");
            Console.WriteLine("Cupos habilitados: " + TOTAL_CUPOS);
            Console.WriteLine("Edad minima       : " + EDAD_MINIMA + " anios");
            Console.WriteLine();

            // ---------- 4. REGISTRO DE LOS 3 JUGADORES ----------
            Console.WriteLine("--- REGISTRO DE JUGADORES ---");
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

            // ---------- 5. PRIMERA DECISION: ELEGIR JUGADOR ----------
            Console.WriteLine("--- SELECCION DE JUGADOR ---");
            Console.WriteLine("1) " + jugador1);
            Console.WriteLine("2) " + jugador2);
            Console.WriteLine("3) " + jugador3);
            Console.Write("Que jugador entra a la arena (1-3): ");
            opcionJugador = int.Parse(Console.ReadLine());

            if (opcionJugador == 1)
            {
                jugadorElegido = jugador1;
                numeroJugador = 1;
            }
            else if (opcionJugador == 2)
            {
                jugadorElegido = jugador2;
                numeroJugador = 2;
            }
            else if (opcionJugador == 3)
            {
                jugadorElegido = jugador3;
                numeroJugador = 3;
            }
            else
            {
                jugadorElegido = "SIN JUGADOR";
                numeroJugador = 0;
                estadoFinal = ESTADO_FUERA;
                Console.WriteLine();
                Console.WriteLine("Opcion invalida. No hay jugador para competir.");
            }

            // Solo se continua si se eligio un jugador valido
            if (estadoFinal == "")
            {
                Console.WriteLine();
                Console.WriteLine("Jugador seleccionado: 00" + numeroJugador + " - " + jugadorElegido);

                // ---------- 6. CONTROL DE EDAD ----------
                Console.Write("Ingrese la edad de " + jugadorElegido + ": ");
                edad = int.Parse(Console.ReadLine());

                if (edad < EDAD_MINIMA)
                {
                    estadoFinal = ESTADO_FUERA;
                    Console.WriteLine("ACCESO DENEGADO. " + jugadorElegido + " no cumple la edad minima.");
                }
                else
                {
                    puntaje = puntaje + 20;
                    Console.WriteLine("ACCESO PERMITIDO. " + jugadorElegido + " puede competir.");
                }

                // ---------- 7. SELECCION DE PRUEBA ----------
                if (estadoFinal == "")
                {
                    Console.WriteLine();
                    Console.WriteLine("--- SELECCION DE PRUEBA ---");
                    Console.WriteLine("1) " + PRUEBA_1);
                    Console.WriteLine("2) " + PRUEBA_2 + " (galleta de azucar)");
                    Console.WriteLine("3) " + PRUEBA_3);
                    Console.Write("Elija la prueba (1-3): ");
                    opcionPrueba = int.Parse(Console.ReadLine());

                    if (opcionPrueba == 1)
                    {
                        pruebaElegida = PRUEBA_1;
                        Console.WriteLine();
                        Console.WriteLine("PRUEBA: " + PRUEBA_1);
                        Console.WriteLine("La muneca gigante gira la cabeza. Que hace " + jugadorElegido + "?");
                        Console.WriteLine("1) Seguir corriendo");
                        Console.WriteLine("2) Quedarse inmovil");
                        Console.WriteLine("3) Esconderse detras de otro");
                        Console.Write("Decision: ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 2)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 70;
                            Console.WriteLine(jugadorElegido + " se queda inmovil justo a tiempo. Sobrevive!");
                        }
                        else if (decision == 3)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 40;
                            Console.WriteLine(jugadorElegido + " se esconde detras de otro jugador. Sobrevive!");
                        }
                        else if (decision == 1)
                        {
                            estadoFinal = ESTADO_FUERA;
                            Console.WriteLine(jugadorElegido + " sigue corriendo y es detectado. Eliminado.");
                        }
                        else
                        {
                            estadoFinal = ESTADO_FUERA;
                            Console.WriteLine("Respuesta invalida. " + jugadorElegido + " queda eliminado.");
                        }
                    }
                    else if (opcionPrueba == 2)
                    {
                        pruebaElegida = PRUEBA_2;
                        Console.WriteLine();
                        Console.WriteLine("PRUEBA: " + PRUEBA_2 + " (galleta de azucar)");
                        Console.WriteLine("Elija la figura de la galleta:");
                        Console.WriteLine("1) Triangulo  (facil)");
                        Console.WriteLine("2) Estrella   (medio)");
                        Console.WriteLine("3) Sombrilla  (dificil)");
                        Console.Write("Figura elegida por " + jugadorElegido + ": ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 50;
                            Console.WriteLine(jugadorElegido + " talla el triangulo sin problemas. Sobrevive!");
                        }
                        else if (decision == 2)
                        {
                            // if anidado: la estrella exige una segunda decision
                            Console.WriteLine("La estrella tiene bordes delicados.");
                            Console.Write("Lame la galleta para separar el borde? (1 = si / 2 = no): ");
                            int decisionEstrella = int.Parse(Console.ReadLine());

                            if (decisionEstrella == 1)
                            {
                                estadoFinal = ESTADO_VIVO;
                                puntaje = puntaje + 65;
                                Console.WriteLine("La tecnica de lamer funciona. " + jugadorElegido + " sobrevive!");
                            }
                            else
                            {
                                estadoFinal = ESTADO_FUERA;
                                Console.WriteLine("La estrella se quiebra. " + jugadorElegido + " es eliminado.");
                            }
                        }
                        else if (decision == 3)
                        {
                            // if anidado: la sombrilla es la figura mas dificil
                            Console.WriteLine("La sombrilla es la figura mas dificil del juego.");
                            Console.Write("Usa la aguja calentada con el encendedor? (1 = si / 2 = no): ");
                            int decisionSombrilla = int.Parse(Console.ReadLine());

                            if (decisionSombrilla == 1)
                            {
                                estadoFinal = ESTADO_VIVO;
                                puntaje = puntaje + 80;
                                Console.WriteLine("La aguja caliente corta el azucar. " + jugadorElegido + " lo logra!");
                            }
                            else
                            {
                                estadoFinal = ESTADO_FUERA;
                                Console.WriteLine("Sin la aguja calentada la sombrilla se rompe. " + jugadorElegido + " es eliminado.");
                            }
                        }
                        else
                        {
                            estadoFinal = ESTADO_FUERA;
                            Console.WriteLine("Figura inexistente. " + jugadorElegido + " es eliminado.");
                        }
                    }
                    else if (opcionPrueba == 3)
                    {
                        pruebaElegida = PRUEBA_3;
                        Console.WriteLine();
                        Console.WriteLine("PRUEBA: " + PRUEBA_3);
                        Console.WriteLine("El equipo esta sobre el puente. Que estrategia usa " + jugadorElegido + "?");
                        Console.WriteLine("1) Jalar con toda la fuerza");
                        Console.WriteLine("2) Inclinarse hacia atras");
                        Console.WriteLine("3) Soltar la cuerda");
                        Console.Write("Decision: ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 2)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 75;
                            Console.WriteLine(jugadorElegido + " se inclina hacia atras. El equipo gana. Sobrevive!");
                        }
                        else if (decision == 1)
                        {
                            estadoFinal = ESTADO_FUERA;
                            Console.WriteLine(jugadorElegido + " jala con toda la fuerza y pierde el equilibrio. Eliminado.");
                        }
                        else if (decision == 3)
                        {
                            estadoFinal = ESTADO_FUERA;
                            Console.WriteLine(jugadorElegido + " suelta la cuerda. Eliminado.");
                        }
                        else
                        {
                            estadoFinal = ESTADO_FUERA;
                            Console.WriteLine("Sin estrategia definida. " + jugadorElegido + " es eliminado.");
                        }
                    }
                    else
                    {
                        estadoFinal = ESTADO_FUERA;
                        pruebaElegida = "Ninguna";
                        Console.WriteLine("Esa prueba no existe. " + jugadorElegido + " es eliminado.");
                    }
                }
            }

            // ---------- 8. CLASIFICACION POR PUNTAJE ----------
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

            // ---------- 9. REPORTE FINAL ----------
            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine("   REPORTE FINAL - " + NOMBRE_JUEGO);
            Console.WriteLine("====================================================");
            Console.WriteLine("Jugador       : " + jugadorElegido);
            Console.WriteLine("Numero        : 00" + numeroJugador);
            Console.WriteLine("Prueba        : " + pruebaElegida);
            Console.WriteLine("Estado        : " + estadoFinal);
            Console.WriteLine("Puntaje       : " + puntaje + " / 100");
            Console.WriteLine("Clasificacion : " + clasificacion);

            if (estadoFinal == ESTADO_VIVO)
            {
                Console.WriteLine("Premio en juego: " + PREMIO_TOTAL + " wones");
            }

            Console.WriteLine("====================================================");

            Console.ReadKey();
        }
    }
}


