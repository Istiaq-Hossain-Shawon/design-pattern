using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern.Product
{
    /// <summary>

    /// The 'ConcreteBuilder2' class

    /// </summary>

    class CarBuilder : VehicleBuilder
    {
        Vehicle vehicle;
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        public override void BuildFrame()
        {
            vehicle.Frame = "Car Frame";
        }

        public override void BuildEngine()
        {
            vehicle.Engine = "2500 cc";
        }

        public override void BuildWheels()
        {
            vehicle.Wheels = "4";
        }

        public override void BuildDoors()
        {
            vehicle.Doors = "4";
        }
        public override Vehicle GetVehicle()
        {
            return vehicle;
        } 
    }
}
