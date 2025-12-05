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

            Console.WriteLine(value1);
        }
    }
}