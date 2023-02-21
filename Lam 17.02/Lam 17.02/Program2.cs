using System;

class Program2
{
    static void MyCustomMethod()
    {
        
        Random rand = new Random();
        Func<int>[] methods = {
            () => rand.Next(10),
            () => rand.Next(10),
            () => rand.Next(10),
            () => rand.Next(10)
        };

        Func<Func<int>[], double> Average = delegate (Func<int>[] funcs) {
            double sum = 0;
            foreach (var func in funcs)
            {
                sum += func();
            }
            return sum / funcs.Length;
        };

      
        double avg = Average(methods);
        Console.WriteLine($"Average: {avg}");
        static void Main()
        {
            MyCustomMethod();
        }
    }
}
