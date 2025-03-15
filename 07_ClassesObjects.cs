using System;

class Car
{
    public string Brand;
    public int Year;

    public void Display()
    {
        Console.WriteLine($"Car Brand: {Brand}, Year: {Year}");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Brand = "Toyota";
        myCar.Year = 2022;
        myCar.Display();
    }
}
