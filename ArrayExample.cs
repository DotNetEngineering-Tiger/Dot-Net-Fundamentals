using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine(numbers[2]); // Output: 3

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine($"Array Length: {numbers.Length}");
    }
}
