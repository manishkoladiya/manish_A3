using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manish_A3
{
    internal class RentalAgency
    {
        private List<Vehicle> Fleet = new List<Vehicle>();
        public decimal TotalRevenue { get; private set; }

        public void AddVehicle(Vehicle vehicle)
        {
            Fleet.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            Fleet.Remove(vehicle);
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            TotalRevenue += vehicle.RentalPrice * days;
        }

        public void DisplayFleetDetails()
        {
            foreach (var vehicle in Fleet)
            {
                vehicle.DisplayDetails();
            }
        }
    }
}
