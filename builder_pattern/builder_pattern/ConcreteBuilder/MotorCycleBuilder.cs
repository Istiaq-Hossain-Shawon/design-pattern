using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern.Product
{
    /// <summary>

    /// The 'ConcreteBuilder1' class

    /// </summary>

    class MotorCycleBuilder : VehicleBuilder
    {
        Vehicle vehicle;

        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");
        }

        public override void BuildFrame()
        {
            vehicle.Frame = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            vehicle.Engine = "500 cc";
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
