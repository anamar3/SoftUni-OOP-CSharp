using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus: Vehicle
    {
        public Bus(double capacity,double fuelQuantity, double fuelCon):base(capacity,fuelQuantity,fuelCon)
        {

        }
        public override double FuelConsumption  => IsEmpty ? base.FuelConsumption:base.FuelConsumption+1.4;
    
    }
}
