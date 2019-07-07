using builder_pattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder;

            // Create shop with vehicle builders
            ShopDirector shopDirector;
            shopDirector = new ShopDirector(new ScooterBuilder());
            shopDirector.Construct();
            Console.WriteLine(shopDirector.GetVehicle().Doors);

            shopDirector = new ShopDirector(new CarBuilder());
            shopDirector.Construct();
            Console.WriteLine(shopDirector.GetVehicle());

            shopDirector = new ShopDirector(new MotorCycleBuilder());
            shopDirector.Construct();
            Console.WriteLine(shopDirector.GetVehicle());

            // Wait for user

            Console.ReadKey();
        }
    }
}
