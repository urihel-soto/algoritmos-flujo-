
using System;

class Program
{
    // Funcion para determinar la categoria por edad
    static string Categoria(int edad)
    {
        if (edad < 13)
        {
            return "Niño";
        }
        else if (edad < 18)
        {
            return "Adolescente";
        }
        else if (edad < 60)
        {
            return "Adulto";
        }
        else
        {
            return "Adulto mayor";
        }
    }

    // Funcion para mostrar tarifas
    static void Tarifas()
    {
        Console.WriteLine("\n=== TARIFAS DEL CINE ===");
        Console.WriteLine("Menores de 18: No pueden entrar");
        Console.WriteLine("Mujeres: Entrada gratis");
        Console.WriteLine("Hombres: RD$300");
    }

   
