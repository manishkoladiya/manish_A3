using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manish_A3
{
    internal class Truck : Vehicle
    {
        public double Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }

        public Truck(string model, string manufacturer, int year, decimal rentalPrice, double capacity, string truckType, bool fourWheelDrive)
            : base(model, manufacturer, year, rentalPrice)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Truck Type: {TruckType}");
            Console.WriteLine($"Four Wheel Drive: {FourWheelDrive} \n");

        }
    }
}
