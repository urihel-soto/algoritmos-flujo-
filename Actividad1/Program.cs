
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

   
// Reto extra: mostrar mayor, menor y valor del centro
    static void CompararMontos()
    {
        Console.WriteLine("\n=== COMPARAR 3 MONTOS ===");

        Console.Write("Ingrese el primer monto: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo monto: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer monto: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double mayor = Math.Max(num1, Math.Max(num2, num3));
        double menor = Math.Min(num1, Math.Min(num2, num3));

        double centro = num1 + num2 + num3 - mayor - menor;

        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);
        Console.WriteLine("Valor del centro: " + centro);
    }

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== CINE CLUB ===");
            Console.WriteLine("1) Registrar");
            Console.WriteLine("2) Tarifas");
            Console.WriteLine("3) Comparar montos");
            Console.WriteLine("4) Salir");

            Console.Write("Seleccione una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("\nIngrese su nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese su edad: ");
                    int edad = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Ingrese su genero (F/M): ");
                    string genero = Console.ReadLine().ToUpper();

                    string categoria = Categoria(edad);

                    if (edad < 18)
                    {
                        Console.WriteLine("\n" + nombre.ToUpper() +
                            " | " + categoria + " | NO PUEDE ENTRAR");
                    }
                    else if (genero == "F")
                    {
                        Console.WriteLine("\n" + nombre.ToUpper() +
                            " | " + categoria + " | Entrada GRATIS");
                    }
                    else if (genero == "M")
                    {
                        Console.WriteLine("\n" + nombre.ToUpper() +
                            " | " + categoria + " | Debe pagar RD$300");
                    }
                    else
                    {
                        Console.WriteLine("Genero no valido.");
                    }

                    break;

                case 2:
                    Tarifas();
                    break;

                case 3:
                    CompararMontos();
                    break;

                case 4:
                    Console.WriteLine("\nGracias por visitar CINE CLUB.");
                    break;

                default:
                    Console.WriteLine("\nOpcion no valida.");
                    break;
            }

        } while (opcion != 4);
    }
}
