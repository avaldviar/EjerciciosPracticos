﻿namespace area_de_un_circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double area;

            Console.WriteLine("Programa que calcula el area de un circulo");
            Console.WriteLine("");
            Console.Write("Digite el radio del circulo: ");
            radio = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("El area del circulo es de: " + area);

        }
    }
}
