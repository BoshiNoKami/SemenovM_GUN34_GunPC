using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter number.");

        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a number!");
            return;
        }

        Console.WriteLine("Please enter number.");

        if (!Int32.TryParse(Console.ReadLine(),out var b))
        {
            Console.WriteLine("Not a number!");
            return;
        }

        Console.WriteLine("Please enter +,-,/,* or %.");

        var s = Console.ReadLine();
        var boolVar= true;
        if (s.Length == 0 || s.Length > 1 && !boolVar)
        {
            Console.WriteLine("Wrong sing");
            return;
        }

        switch (s[0])
        {
            case '+':
                Console.WriteLine(Convert.ToString(a + b, 2));
                Console.WriteLine(Convert.ToString(a + b, 10));
                Console.WriteLine(Convert.ToString(a + b, 16));
                break;
            case '-':
                Console.WriteLine(Convert.ToString(a - b, 2));
                Console.WriteLine(Convert.ToString(a - b, 10));
                Console.WriteLine(Convert.ToString(a - b, 16));
                break;
            case '/':
                Console.WriteLine(Convert.ToString(a / b, 2));
                Console.WriteLine(Convert.ToString(a / b, 10));
                Console.WriteLine(Convert.ToString(a / b, 16));
                break;
            case '%':
                Console.WriteLine(Convert.ToString(a % b, 2));
                Console.WriteLine(Convert.ToString(a % b, 10));
                Console.WriteLine(Convert.ToString(a % b, 16));
                break;
            case '*':
                Console.WriteLine(Convert.ToString(a * b, 2));
                Console.WriteLine(Convert.ToString(a * b, 10));
                Console.WriteLine(Convert.ToString(a * b, 16));
                break;
            default:
                Console.WriteLine("Wrong sing");
                break;

        }
    }
}
