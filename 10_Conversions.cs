using System;

class Program
{
    static void Main()
    {
        // Implicit Conversion
        int num = 10;
        double dblNum = num; // Implicit conversion
        Console.WriteLine($"Implicit Conversion: Integer {num} -> Double {dblNum}");

        // Explicit Conversion (Casting)
        double value = 9.78;
        int intValue = (int)value;
        Console.WriteLine($"Explicit Conversion: Double {value} -> Integer {intValue}");

        // Convert Class
        string str = "123";
        int convertedNum = Convert.ToInt32(str);
        Console.WriteLine($"Convert.ToInt32: {convertedNum}");

        // Parse Method
        int parsedNum = int.Parse(str);
        Console.WriteLine($"int.Parse: {parsedNum}");

        // TryParse Method
        bool success = int.TryParse("456", out int tryParsedNum);
        Console.WriteLine($"TryParse Success: {success}, Value: {tryParsedNum}");

        // ToString Method
        string strValue = num.ToString();
        Console.WriteLine($"ToString Conversion: {strValue}");
    }
}
