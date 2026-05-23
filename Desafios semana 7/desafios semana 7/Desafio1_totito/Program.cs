using System;

class Program
{
    static char[,] tablero = new char[3, 3];
    static char jugadorActual = 'X';

    static void Main()
    {
        InicializarTablero();

        bool juegoTerminado = false;

        while (!juegoTerminado)
        {
            Console.Clear();
            MostrarTablero();

            Console.WriteLine($"Turno del jugador: {jugadorActual}");

            int fila = PedirNumero("Fila (0-2): ");
            int columna = PedirNumero("Columna (0-2): ");

            if (tablero[fila, columna] != ' ')
            {
                Console.WriteLine("Casilla ocupada. Presiona una tecla...");
                Console.ReadKey();
                continue;
            }

            tablero[fila, columna] = jugadorActual;

            if (VerificarGanador())
            {
                Console.Clear();
                MostrarTablero();
                Console.WriteLine($"¡Jugador {jugadorActual} gana!");
                juegoTerminado = true;
            }
            else if (TableroLleno())
            {
                Console.Clear();
                MostrarTablero();
                Console.WriteLine("¡Empate!");
                juegoTerminado = true;
            }
            else
            {
                CambiarJugador();
            }
        }

        Console.WriteLine("Fin del juego.");
    }

    static void InicializarTablero()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                tablero[i, j] = ' ';
    }

    static void MostrarTablero()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($" {tablero[i, 0]} | {tablero[i, 1]} | {tablero[i, 2]} ");
            if (i < 2) Console.WriteLine("---|---|---");
        }
    }

    static int PedirNumero(string mensaje)
    {
        int valor;

        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out valor) && valor >= 0 && valor <= 2)
                return valor;

            Console.WriteLine("Entrada inválida. Intenta de nuevo.");
        }
    }

    static void CambiarJugador()
    {
        jugadorActual = (jugadorActual == 'X') ? 'Y' : 'X';
    }

    static bool VerificarGanador()
    {
        // Filas
        for (int i = 0; i < 3; i++)
            if (tablero[i, 0] == jugadorActual &&
                tablero[i, 1] == jugadorActual &&
                tablero[i, 2] == jugadorActual)
                return true;

        // Columnas
        for (int i = 0; i < 3; i++)
            if (tablero[0, i] == jugadorActual &&
                tablero[1, i] == jugadorActual &&
                tablero[2, i] == jugadorActual)
                return true;

        // Diagonales
        if (tablero[0, 0] == jugadorActual &&
            tablero[1, 1] == jugadorActual &&
            tablero[2, 2] == jugadorActual)
            return true;

        if (tablero[0, 2] == jugadorActual &&
            tablero[1, 1] == jugadorActual &&
            tablero[2, 0] == jugadorActual)
            return true;

        return false;
    }

    static bool TableroLleno()
    {
        foreach (char c in tablero)
            if (c == ' ') return false;

        return true;
    }
}