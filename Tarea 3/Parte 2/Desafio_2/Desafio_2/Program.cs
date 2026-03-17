
using System;

namespace Desafio_2
{
    class Program
    {
        // Jugador récord inicial 
        static int puntajeRecord = 100;
        static string jugadorRecord = "Angel";

        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE PUNTAJES ===\n");

            // Mostrar récord actual
            Console.WriteLine("Puntaje récord actual: " + puntajeRecord);
            Console.WriteLine("Jugador récord actual: " + jugadorRecord);

            // Ingreso de un nuevo jugador
            Console.Write("\nIngrese nombre del nuevo jugador: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese puntaje del nuevo jugador: ");
            int puntaje = Convert.ToInt32(Console.ReadLine());

            // Evaluación
            ActualizarPuntaje(puntaje, nombre);

            Console.ReadLine();
        }

        static void ActualizarPuntaje(int puntaje, string nombreJugador)
        {
            if (puntaje > puntajeRecord)
            {
                puntajeRecord = puntaje;
                jugadorRecord = nombreJugador;

                Console.WriteLine("\nLa nueva puntuación más alta es " + puntajeRecord);
                Console.WriteLine("La puntuación más alta fue lograda por " + jugadorRecord);
            }
            else
            {
                Console.WriteLine("\nLa puntuación más alta de " + puntajeRecord +
                " no se ha podido superar, y aún está en manos de " + jugadorRecord);
            }
        }
    }
}