using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerPoo;

namespace TallerPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Ingrese una opción: \n 1: Electrodomestico 2: Nevera 3: Televisión");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese el precio del electrodomestico:");
                    double precio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el color del electrodomestico:");
                    string color = Console.ReadLine();
                    Console.WriteLine("Ingrese el consumo electrico del electrodomestico:");
                    string consumoElec = Console.ReadLine();
                    Console.WriteLine("Ingrese el peso del electrodomestico:");
                    double peso = double.Parse(Console.ReadLine());
                    Lavadora lavadora = new Lavadora(precio, peso, consumoElec, color);
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Ingrese el precio de la lavadora:");
                    double precio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el color la lavadora:");
                    string color = Console.ReadLine();
                    Console.WriteLine("Ingrese el consumo electrico de la lavadora:");
                    string consumoElec = Console.ReadLine();
                    Console.WriteLine("Ingrese el peso de la lavadora:");
                    double peso = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la carga de la lavadora");
                    //Appliances nevera = new nevera();
                }
            }

        }
    }
}

