using System;

namespace Calculator 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Welcome to Calculator");
            Console.WriteLine("What you wish to do?");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Divsion");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("--------------------");
            Console.WriteLine("Select an option: ");
            short res = short.Parse(Console.ReadLine()); // short because is from 1-4, not big numbers

            switch(res){
                case 1: Sum(); break;
                case 2: Sub(); break;
                case 3: Multi(); break;
                case 4: Div(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Sum()
        {
            Console.Clear();
            
            Console.WriteLine("First value: ");
            float firstValue = float.Parse(Console.ReadLine()); // .Parse because convert a string to a float 
            Console.WriteLine("Second Value: ");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = firstValue + secondValue;
            Console.WriteLine($"The sum result is {result}");
            Console.ReadKey();
            Menu();
        }

        static void Sub()
        {
            Console.Clear();
            
            Console.WriteLine("First value: ");
            float firstValue = float.Parse(Console.ReadLine()); // .Parse because convert a string to a float 
            Console.WriteLine("Second Value: ");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = firstValue - secondValue;
            Console.WriteLine($"The subtraction result is {result}");
            Console.ReadKey();
            Menu();
        }

        static void Multi()
        {
            Console.Clear();
            
            Console.WriteLine("First value: ");
            float firstValue = float.Parse(Console.ReadLine()); // .Parse because convert a string to a float 
            Console.WriteLine("Second Value: ");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = firstValue * secondValue;
            Console.WriteLine($"The multiplication result is {result}");
            Console.ReadKey();
            Menu();
        }

        static void Div()
        {
            Console.Clear();
            
            Console.WriteLine("First value: ");
            float firstValue = float.Parse(Console.ReadLine()); // .Parse because convert a string to a float 
            Console.WriteLine("Second Value: ");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = firstValue / secondValue;
            Console.WriteLine($"The division result is {result}");
            Console.ReadKey();
            Menu();
        }
    }
}