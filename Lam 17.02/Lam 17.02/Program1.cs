using System;

class Program1
{
    static void Main()
    {
        Func<double, double, double> Add = (a, b) => a + b;
        Func<double, double, double> Sub = (a, b) => a - b;
        Func<double, double, double> Mul = (a, b) => a * b;
        Func<double, double, double> Div = (a, b) => b != 0 ? a / b : throw new DivideByZeroException();

        Console.WriteLine("Enter two numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the operator (+, -, *, /):");
        string op = Console.ReadLine();

        double result;
        switch (op)
        {
            case "+":
                result = Add(a, b);
                break;
            case "-":
                result = Sub(a, b);
                break;
            case "*":
                result = Mul(a, b);
                break;
            case "/":
                try
                {
                    result = Div(a, b);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Division by zero");
                    return;
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator");
                return;
        }

        // Print the result
        Console.WriteLine($"Result: {result}");
    }
}
