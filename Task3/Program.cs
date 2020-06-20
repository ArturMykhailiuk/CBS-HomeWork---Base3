using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nТранспортное средство: Автомобиль");
            Vehicle vehicle1 = new Vehicle(new Car());
            vehicle1.VehicleInfo();

            Console.WriteLine("\nТранспортное средство: Самолет");
            Vehicle vehicle2 = new Vehicle(new Plane());
            vehicle2.VehicleInfo();

            Console.WriteLine("\nТранспортное средство: Корабль");
            Vehicle vehicle3 = new Vehicle(new Ship());
            vehicle3.VehicleInfo();
        }
    }
}
