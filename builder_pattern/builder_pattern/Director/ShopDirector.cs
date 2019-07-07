using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern.Product
{
    /// <summary>

    /// The 'Director' class

    /// </summary>

    class ShopDirector
    {
        private VehicleBuilder _vehicleBuilder;
        public ShopDirector(VehicleBuilder vehicleBuilder)
        {
            _vehicleBuilder = vehicleBuilder;  
        } 
       
        public void Construct()
        {
            _vehicleBuilder.BuildFrame();
            _vehicleBuilder.BuildEngine();
            _vehicleBuilder.BuildWheels();
            _vehicleBuilder.BuildDoors();
        }
        public Vehicle GetVehicle()
        {
            return _vehicleBuilder.GetVehicle();
        }  
    }
}
