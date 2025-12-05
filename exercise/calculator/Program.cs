using System;

namespace Calculator
{
    class Program
    {
        static void Main(string [] args)
        {
           // Sum();
           Subtraction();
        }

        static void Sum()
        {
             Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

             Console.WriteLine("Segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = value1 + value2;

            Console.WriteLine("");

            Console.WriteLine("O resultado da soma é: " + result); // concatenacao

            Console.ReadKey();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

             Console.WriteLine("Segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = value1 - value2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é: {result}"); // interpolacao

            Console.ReadKey();
        }
    }
}