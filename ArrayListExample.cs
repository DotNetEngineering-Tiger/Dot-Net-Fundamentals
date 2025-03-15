using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList { 10, "Hello", 3.14 };
        list.Add(20);
        list.Add("World");

        list.Remove(10);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
