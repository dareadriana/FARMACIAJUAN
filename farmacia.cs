using System;
using System.Collections.Generic;

class Program
{
    static List<string> nombres = new List<string>();
    static List<int> cantidades = new List<int>();
    static List<double> precios = new List<double>();
    static double totalVentas = 0;

    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\nFARMACIA");
            Console.WriteLine("1. Registrar medicamento");
            Console.WriteLine("2. Consultar inventario");
            Console.WriteLine("3. Vender medicamento");
            Console.WriteLine("4. Total vendido");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");

            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1) Registrar();
            else if (opcion == 2) Consultar();
            else if (opcion == 3) Vender();
            else if (opcion == 4) MostrarTotal();

        } while (opcion != 5);
    }

    static void Registrar()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.Write("Precio: ");
        double precio = double.Parse(Console.ReadLine());

        nombres.Add(nombre);
        cantidades.Add(cantidad);
        precios.Add(precio);

        Console.WriteLine("Medicamento registrado");
    }

    static void Consultar()
    {
        Console.WriteLine("\nINVENTARIO:");
        for (int i = 0; i < nombres.Count; i++)
        {
            Console.WriteLine(
                nombres[i] +
                " | Cantidad: " + cantidades[i] +
                " | Precio: " + precios[i]
            );
        }
    }

    static void Vender()
    {
        Console.Write("Medicamento a vender: ");
        string buscar = Console.ReadLine();

        for (int i = 0; i < nombres.Count; i++)
        {
            if (nombres[i] == buscar)
            {
                Console.Write("Cantidad a vender: ");
                int venta = int.Parse(Console.ReadLine());

                if (venta <= cantidades[i])
                {
                    cantidades[i] -= venta;
                    totalVentas += venta * precios[i];
                    Console.WriteLine("Venta realizada");
                }
                else
                {
                    Console.WriteLine("No hay suficiente stock");
                }
                return;
            }
        }

        Console.WriteLine("Medicamento no encontrado");
    }

    static void MostrarTotal()
    {
        Console.WriteLine("Total vendido: " + totalVentas);
    }
}
