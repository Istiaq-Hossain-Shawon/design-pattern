using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern.Product
{
    /// <summary>

    /// The 'Builder' abstract class

    /// </summary>

    abstract class VehicleBuilder
    {
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
        public abstract Vehicle GetVehicle();  
        
    }
}
