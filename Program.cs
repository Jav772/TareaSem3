using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    internal class Program
    {
        static void Main()
        {
            IngresarDatos();
            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
        }
        static int codigo, cantidad;
        static double precio, subtotal, iva, total;
        static string nombre;
        const double TASA_IVA = 0.13;

        public static void IngresarDatos()
        {
            Console.WriteLine("Digite el código:");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el precio:");
            precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Digite la cantidad:");
            cantidad = int.Parse(Console.ReadLine());

            subtotal = precio * cantidad;
            iva = subtotal * TASA_IVA;
            total = subtotal + iva;


            Console.WriteLine("--- Factura ---");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Subtotal: {subtotal}");
            Console.WriteLine($"IVA ({TASA_IVA * 100}%): {iva}");
            Console.WriteLine($"Total a pagar: {total}");

        }

    }
}