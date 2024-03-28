using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manish_A3
{
    internal class Vehicle
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public decimal RentalPrice { get; set; }

        public Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;
        }

        public virtual void DisplayDetails()
        {

            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Price $: {RentalPrice}");

        }
    }
}
