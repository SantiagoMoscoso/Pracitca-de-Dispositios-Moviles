using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // la posición 0 de nombres corresponde a la posición 0 de precios, y así sucesivamente.
        List<string> nombres = new List<string>();
        List<decimal> precios = new List<decimal>();

        Console.Write("¿Cuántos productos deseas registrar? ");
        int cantidad = int.Parse(Console.ReadLine());

        // Primer for: recorre "cantidad" veces para pedir nombre y precio de cada producto,
        // y los va agregando a las dos listas.
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"\nNombre del producto {i + 1}: ");
            string nombre = Console.ReadLine();
            nombres.Add(nombre);

            Console.Write($"Precio del producto {i + 1}: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            precios.Add(precio);
        }

        // Segundo for: recorre las listas ya llenas para mostrar la información.
        // Como nombres y precios están sincronizadas por índice, usamos el mismo "i" para ambas.
        Console.WriteLine("\n=== PRODUCTOS ===");
        for (int i = 0; i < nombres.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {nombres[i]} ${precios[i]:N0}");
        }
    }
}