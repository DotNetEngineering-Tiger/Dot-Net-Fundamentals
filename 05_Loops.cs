using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
            Console.WriteLine($"For loop iteration: {i}");

        int j = 0;
        while (j < 5)
        {
            Console.WriteLine($"While loop iteration: {j}");
            j++;
        }

        int k = 0;
        do
        {
            Console.WriteLine($"Do-while loop iteration: {k}");
            k++;
        } while (k < 5);
    }
}
