namespace saludar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leer un nombre y Saludarlo
            string nombre;
            string apellido;
            Console.WriteLine("¿Cuál es tu nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine("¿Cuál es tu apellido?");
            apellido = Console.ReadLine();
            Console.WriteLine($"Hola {nombre} {apellido}, mucho gusto");
        }
    }
}
