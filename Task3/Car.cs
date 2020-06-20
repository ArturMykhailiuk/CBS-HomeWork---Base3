using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Car : Vehicle
    {
        public override void VehicleInfo()
        {
            Price = 20000;
            Since = 2020;
            Speed = 220;
            
            Console.WriteLine("Цена: {0} USD", Price);
            Console.WriteLine("Год производства: {0} г.", Since);
            Console.WriteLine("Скорость передвижения: {0} км/ч", Speed);
        }
    }
}
