using System;

class Program
{
    static void Main()
    {
        try
        {
            int x = 10, y = 0;
            Console.WriteLine(x / y);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero!");
        }
    }
}
