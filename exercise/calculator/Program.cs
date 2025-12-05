using System;

namespace Calculator
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

             Console.WriteLine("Segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = value1 + value2;

            Console.WriteLine("");

            Console.WriteLine("O resultado é: " + result);
        }
    }
}