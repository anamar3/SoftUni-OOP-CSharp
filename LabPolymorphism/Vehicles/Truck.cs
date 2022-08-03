using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck: Vehicle
    {
        public Truck(double capacity,double fQunan,double fConsum): base(capacity,fQunan,fConsum)
        {
            
        }
       
        public override double FuelConsumption => base.FuelConsumption + 1.6;

       
        public override void Refuel(double litters)
        {
            litters *= 0.95;
            base.Refuel(litters);

        }
    }
}
