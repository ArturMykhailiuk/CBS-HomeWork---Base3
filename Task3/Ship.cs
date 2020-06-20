using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Ship : Vehicle
    {
        int passengers = 2000;
        string seaport = "Маями";

        public override void VehicleInfo()
        {
            Price = 50000000;
            Since = 2018;
            Speed = 40;

            Console.WriteLine("Цена: {0} USD", Price);
            Console.WriteLine("Год производства: {0} г.", Since);
            Console.WriteLine("Скорость передвижения: {0} км/ч", Speed);
            Console.WriteLine("Количество посадочных мест: {0} чел.", passengers);
            Console.WriteLine("Порт приписки: {0}", seaport);
        }
    }
}
