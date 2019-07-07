using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern.Product
{
    /// <summary>

    /// The 'ConcreteBuilder3' class

    /// </summary>

    class ScooterBuilder : VehicleBuilder
    {
        Vehicle vehicle;
        public ScooterBuilder()
        {
            vehicle = new Vehicle("Scooter");
        }

        public override void BuildFrame()
        {
            vehicle.Frame = "Scooter Frame";
        }

        public override void BuildEngine()
        {
            vehicle.Engine = "50 cc";
        }

        public override void BuildWheels()
        {
            vehicle.Wheels = "2";
        }

        public override void BuildDoors()
        {
            vehicle.Doors = "0";
        }
        public override Vehicle GetVehicle()
        {
            return vehicle;
        } 
    }
}
