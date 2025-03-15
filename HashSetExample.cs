using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4 };
        numbers.Add(5);
        numbers.Add(2); // Will not be added (duplicate)

        numbers.Remove(3);

        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
