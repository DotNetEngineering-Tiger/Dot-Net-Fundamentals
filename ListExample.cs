using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string> { "Alice", "Bob" };
        names.Add("Charlie");
        names.Remove("Bob");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        if (names.Contains("Alice"))
        {
            Console.WriteLine("Alice is in the list.");
        }
    }
}
