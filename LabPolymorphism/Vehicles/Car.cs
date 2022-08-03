using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car: Vehicle
    {
        public Car(double capacity,double fuelQun,double FuelCons): base(capacity,fuelQun,FuelCons)
        {

        }
       
        public override double FuelConsumption => base.FuelConsumption + 0.9;

       
      
    }
}
