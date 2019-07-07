using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern.Product
{
    class Vehicle
    {
        private string _vehicleType { set; get; }
        public string Frame { set; get; }
        public string Engine { set; get; }
        public string Wheels { set; get; }
        public string Doors { set; get; }
        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }
    }
}
