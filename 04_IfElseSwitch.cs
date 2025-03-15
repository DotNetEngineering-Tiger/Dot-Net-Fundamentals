using System;

class Program
{
    static void Main()
    {
        int num = 10;
        if (num > 0)
            Console.WriteLine("Positive number");
        else if (num < 0)
            Console.WriteLine("Negative number");
        else
            Console.WriteLine("Zero");
        
        int day = 3;
        switch (day)
        {
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            case 3: Console.WriteLine("Wednesday"); break;
            default: Console.WriteLine("Other day"); break;
        }
    }
}
