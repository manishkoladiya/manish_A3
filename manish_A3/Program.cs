
public class Vehicle
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
public class Car : Vehicle
{
    public int Seats { get; set; }
    public string EngineType { get; set; }
    public string Transmission { get; set; }
    public bool Convertible { get; set; }

    public Car(string model, string manufacturer, int year, decimal rentalPrice, int seats, string engineType, string transmission, bool convertible)
        : base(model, manufacturer, year, rentalPrice)
    {
        Seats = seats;
        EngineType = engineType;
        Transmission = transmission;
        Convertible = convertible;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Seats: {Seats}");
        Console.WriteLine($"Engine Type: {EngineType}");
        Console.WriteLine($"Transmission: {Transmission}");
        Console.WriteLine($"Convertible: {Convertible} \n");

    }
}
public class Truck : Vehicle
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
public class Motorcycle : Vehicle
{
    public int EngineCapacity { get; set; }
    public string FuelType { get; set; }
    public bool HasFairing { get; set; }

    public Motorcycle(string model, string manufacturer, int year, decimal rentalPrice, int engineCapacity, string fuelType, bool hasFairing)
        : base(model, manufacturer, year, rentalPrice)
    {
        EngineCapacity = engineCapacity;
        FuelType = fuelType;
        HasFairing = hasFairing;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Engine Capacity: {EngineCapacity}");
        Console.WriteLine($"Fuel Type: {FuelType}");
        Console.WriteLine($"Has Fairing: {HasFairing}\n");

    }
}
public class RentalAgency
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

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Civic", "Honda", 2018, 150m, 5, "Electric", "Automatic", false);
        Truck truck = new Truck("Silverado", "Chevrolet", 2020, 250m, 1000, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("Ducati Monster", "Ducati", 2022, 150m, 650, "Petrol", true);

        RentalAgency rentalAgency = new RentalAgency();

        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        rentalAgency.RentVehicle(car, 5);

        rentalAgency.DisplayFleetDetails();

        Console.WriteLine($"Total Revenue $: {rentalAgency.TotalRevenue}\n");
    }
}