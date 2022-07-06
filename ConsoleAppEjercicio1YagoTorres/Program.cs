using System;

namespace ConsoleAppEjercicio1YagoTorres
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la velocidad del automóvil");
            var Velocidad = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tiempo del recorrido en minutos");
            var Tiempo = Double.Parse(Console.ReadLine());
            double Distancia = Velocidad * Tiempo;
            Distancia = Distancia * Tiempo;
            Console.WriteLine($"el automóvil recorrió una distancia de: {Distancia} km");
            Console.ReadLine();
        }
    }
}
