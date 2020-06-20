using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Plane : Vehicle
    {
        int passengers = 180;
        int altitude = 10000;
        
        public override void VehicleInfo()
        {
            Price = 20000000;
            Since = 2018;
            Speed = 1000;

            Console.WriteLine("Цена: {0} USD", Price);
            Console.WriteLine("Год производства: {0} г.", Since);
            Console.WriteLine("Скорость передвижения: {0} км/ч", Speed);
            Console.WriteLine("Количество посадочных мест: {0} чел.", passengers);
            Console.WriteLine("Макс. высота полета: {0} м.", altitude);
        }
    }
}
