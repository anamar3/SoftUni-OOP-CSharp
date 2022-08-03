using System;

namespace Vehicles
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] busInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double carFuelQun = double.Parse(carInfo[1]);
            double carFuelCon = double.Parse(carInfo[2]);
            double carCapacity = double.Parse(carInfo[3]);

            double truckFuelQun = double.Parse(truckInfo[1]);
            double truckFuelon = double.Parse(truckInfo[2]);
            double truckCapacity = double.Parse(truckInfo[3]);

            double busFuelQun = double.Parse(busInfo[1]);
            double busFuelon = double.Parse(busInfo[2]);
            double busCapacity = double.Parse(busInfo[3]);


            Car car = new Car(carCapacity,carFuelQun, carFuelCon);
            Truck truck = new Truck(truckCapacity,truckFuelQun, truckFuelon);
            Bus bus = new Bus(busCapacity, busFuelQun, busFuelon);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string action = command[0];
                string vehicle = command[1];
                double value = double.Parse(command[2]);

                IVehicle currentVehicle = null;


                if (vehicle == "Car")
                    currentVehicle = car;
                else if (vehicle == "Bus")
                    currentVehicle = bus;
                else
                    currentVehicle = truck;


                if (action == "Drive")
                {
                    if (currentVehicle.CanDrive(value))
                    {
                        currentVehicle.Drive(value);
                        Console.WriteLine($"{vehicle} travelled {value} km");
                    }
                    else
                        Console.WriteLine($"{vehicle} needs refueling");
                }
                else if (action == "DriveEmpty")
                {
                    bus.IsEmpty = true;
                    if (currentVehicle.CanDrive(value))
                    {
                        
                        bus.Drive(value);
                        bus.IsEmpty = false;
                        Console.WriteLine($"{vehicle} travelled {value} km");
                    }
                    else
                        Console.WriteLine($"{vehicle} needs refueling");

                }
                else if (action == "Refuel")
                {
                    if (currentVehicle.CanRefuel(value))
                        currentVehicle.Refuel(value);
                    else
                        Console.WriteLine($"Cannot fit {value} fuel in the tank");
                }
                else
                {
                    if (currentVehicle.CanRefuel(value))
                        currentVehicle.Refuel(value);
                    else
                        Console.WriteLine($"{vehicle} needs refueling");
                }
                
               
               

            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");



        }
    }

}
