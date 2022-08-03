using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle: IVehicle
    {
        private double FQQ;
        public Vehicle(double tankCamp,double FQQ, double FCC)
        {
            Capacity = tankCamp;
            FuelQuantity = FQQ;
            FuelConsumption = FCC;
            
           
        }

        public double FuelQuantity
        {
            get => FQQ;
            private set
            {
                if (value > Capacity)
                {
                    FQQ = 0;
                }
                else
                {
                    FQQ = value;
                }

            }
        }

        public virtual double FuelConsumption { get; protected set; }
        public double Capacity { get ; }
        public bool IsEmpty { get ; set; }

        public bool CanRefuel(double litters) => litters + FuelQuantity <= Capacity;


        public bool CanDrive(double km)
            => FuelQuantity - (km * FuelConsumption) >= 0;

        public virtual void Drive(double distance)
        {
            if(CanDrive(distance))
            FuelQuantity -= distance * FuelConsumption;
        }
        public virtual void Refuel(double litters)
        {
            if(litters<=0)
            {
                Console.WriteLine( $"Fuel must be a positive number");
            }
            else if(CanRefuel(litters))
            {
                FuelQuantity += litters;
            }
           
        }
    }
}
