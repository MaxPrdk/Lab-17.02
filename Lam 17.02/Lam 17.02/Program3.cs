
Console.Write("Enter the first integer: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second integer: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third integer: ");
int third = Convert.ToInt32(Console.ReadLine());

Func<int, int, int, double> average = delegate (int a, int b, int c)
{
    return (a + b + c) / 3.0;
};

double result = average(first, second, third);
Console.WriteLine("The average of {0}, {1}, and {2} is {3}.", first, second, third, result);