using practica;
using System;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;


class Program
{
    static void Main()
    {
        // Definir las dimensiones de la matriz
        int filas = 5;
        int columnas = 4;

        // Crear una matriz para representar los asientos
        bool[,] asientos = new bool[filas, columnas];

        // Inicializar todos los asientos como libres
        InicializarAsientosLibres(asientos);

        // Mostrar el estado de los asientos
        MostrarEstadoAsientos(asientos);

        // Permitir que el usuario elija asientos manualmente
        ElegirAsientosManualmente(asientos);

        // Mostrar el estado actualizado de los asientos
        MostrarEstadoAsientos(asientos);

        Console.ReadKey();
    }

    static void InicializarAsientosLibres(bool[,] asientos)
    {
        for (int i = 0; i < asientos.GetLength(0); i++)
        {
            for (int j = 0; j < asientos.GetLength(1); j++)
            {
                asientos[i, j] = false; // Marcar como libre
            }
        }
    }

    static void ElegirAsientosManualmente(bool[,] asientos)
    {
        Console.WriteLine("\nElija asientos (ingrese -1 para salir):");

        int fila, columna;

        do
        {
            Console.Write("Fila (-1 para salir): ");
            if (!int.TryParse(Console.ReadLine(), out fila) || fila == -1)
                break;

            Console.Write("Columna: ");
            if (!int.TryParse(Console.ReadLine(), out columna))
                continue;

            if (EsAsientoValido(asientos, fila, columna))
            {
                MarcarAsientoOcupado(asientos, fila, columna);
                Console.WriteLine($"Asiento ({fila}, {columna}) marcado como ocupado.");
            }
            else
            {
                Console.WriteLine("Asiento ocupado o fuera de los límites. Intente de nuevo.");
            }

        } while (true);
    }

    static bool EsAsientoValido(bool[,] asientos, int fila, int columna)
    {
        return fila >= 0 && fila < asientos.GetLength(0) && columna >= 0 && columna < asientos.GetLength(1) && !asientos[fila, columna];
    }

    static void MarcarAsientoOcupado(bool[,] asientos, int fila, int columna)
    {
        asientos[fila, columna] = true; // Marcar como ocupado
    }

    static void MostrarEstadoAsientos(bool[,] asientos)
    {
        Console.WriteLine("Estado de los asientos:");

        for (int i = 0; i < asientos.GetLength(0); i++)
        {
            for (int j = 0; j < asientos.GetLength(1); j++)
            {
                if (asientos[i, j])
                {
                    Console.Write("[X] "); // Asiento ocupado
                }
                else
                {
                    Console.Write("[ ] "); // Asiento libre
                }
            }
            Console.WriteLine(); // Nueva línea para la siguiente fila
        }
    }
}

