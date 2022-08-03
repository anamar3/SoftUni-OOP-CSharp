using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicle
    {
        public double FuelQuantity { get; }
        public double FuelConsumption { get;  }
        public double Capacity { get;  }

        public bool IsEmpty { get; set; }

        public bool CanDrive(double distance);

        public void Drive(double km);

        public void Refuel(double amount);
        public bool CanRefuel(double amount);
    }
}
