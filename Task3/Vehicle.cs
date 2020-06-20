using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Vehicle
    {
        Vehicle vehicle;

        public double Price { get; set; }
        public int Since { get; set; }
        public int Speed { get; set; }

        public Vehicle ()
        {

        }
        
        public Vehicle (Car car)
        {
            vehicle = car;
        }
        public Vehicle(Plane plane)
        {
            vehicle = plane; 
        }
        public Vehicle(Ship ship)
        {
            vehicle = ship;
        }

        virtual public void VehicleInfo()
        {
            vehicle.VehicleInfo();
        }

    }

    
}
