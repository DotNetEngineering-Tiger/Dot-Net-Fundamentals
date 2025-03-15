using System;

interface IVehicle
{
    void Drive();
}

class Car : IVehicle
{
    public void Drive() => Console.WriteLine("Car is driving");
}

class Program
{
    static void Main()
    {
        IVehicle vehicle = new Car();
        vehicle.Drive();
    }
}
