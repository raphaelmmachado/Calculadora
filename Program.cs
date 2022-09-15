// See https://aka.ms/new-console-template for more information
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
            Console.WriteLine("Select your operation");
            Console.WriteLine("1 - ADD");
            Console.WriteLine("2 - SUB");
            Console.WriteLine("3 - MULT");
            Console.WriteLine("4 - DIV");
            Console.WriteLine("5 - EXIT APPLICATION");
            short key = short.Parse(Console.ReadLine()!);
            switch (key)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Sub();
                    break;
                case 3:
                    Mult();
                    break;
                case 4:
                    Div();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter 1,2,3 or 4");
                    break;
            }
        }
        static void Add()
        {
            Console.WriteLine("ADDITION");
            Console.WriteLine("Enter first number");
            float firstValue = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter second number");
            float secondValue = float.Parse(Console.ReadLine()!);
            Console.WriteLine($"Result is: {firstValue + secondValue}");
            Console.ReadKey();
            Menu();
        }
        static void Sub()
        {
            Console.WriteLine("SUBTRACTION");
            Console.WriteLine("Enter first number");
            float firstValue = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter second number");
            float secondValue = float.Parse(Console.ReadLine()!);
            Console.WriteLine($"Result is: {firstValue - secondValue}");
            Console.ReadKey();
            Menu();
        }
        static void Mult()
        {

            Console.WriteLine("MULTIPLICATION");
            Console.WriteLine("Enter first number");
            float firstValue = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter second number");
            float secondValue = float.Parse(Console.ReadLine()!);
            Console.WriteLine($"Result is: {firstValue * secondValue}");
            Console.ReadKey();
            Menu();
        }
        static void Div()
        {
            Console.WriteLine("DIVISION");
            Console.WriteLine("Enter first number");
            float firstValue = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter second number");
            float secondValue = float.Parse(Console.ReadLine()!);
            Console.WriteLine($"Result is : {firstValue / secondValue}");
            Console.ReadKey();
            Menu();
        }
    }
}