using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
         Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha uma das seguintes operações: ");

            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("5- Sair");

            Console.WriteLine("----------------------------");

            short option = short.Parse(Console.ReadLine());

          switch (option)
          {
            case 1: Sum(); break;
            case 2: Subtraction(); break;
            case 3: Multiplication(); break;
            case 4: Division(); break; 
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
          }

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

            Console.WriteLine($"O resultado da soma é: {result}");

            Console.ReadKey();

            Menu();
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

            Console.WriteLine($"O resultado da subtração é: {result}");

            Console.ReadKey();

            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = value1 * value2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da multiplicação é: {result}");

            Console.ReadKey();

            Menu();
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = value1 / value2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da divisão é: {result}");

            Console.ReadKey();

            Menu();
        }

    }
}