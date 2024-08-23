using System;

namespace MayorDeTresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que solicita al usuario que ingrese tres números y determine el mayor
            Console.WriteLine("Ingrese el primer número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            int num3 = int.Parse(Console.ReadLine());
            int mayor = num1;

            if (num2 > mayor)
            {
                mayor = num2;
            }

            if (num3 > mayor)
            {
                mayor = num3;
            }
            Console.WriteLine("El mayor de los tres números es: " + mayor);
        }
    }
}
