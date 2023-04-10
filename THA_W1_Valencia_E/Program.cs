using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Car
{
    private string make;
    public string Make
    {
        get { return make; }
        set { make = value; }
    }
    private string model;
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    private int year;
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    private double price;
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    private string type;
    public string Type
    {
        get { return type; }
        set { type = value; }
    }
}
class ElectricCar : Car
{
    private int batterycapacity;
    public int BatteryCapacity
    {
        get { return batterycapacity; }
        set { batterycapacity = value; }
    }
    public ElectricCar()
    {
        Type = "ElectricCar";
    }
}
class HybridCar : Car
{
    private int gastanksize;
    public int GasTankSize
    {
        get { return gastanksize; }
        set { gastanksize = value; }
    }
    private int batterycapacity;
    public int BatteryCapacity
    {
        get { return batterycapacity; }
        set { batterycapacity = value; }
    }
    public HybridCar()
    {
        Type = "HybridCar";
    }
}
class GasolineCar : Car
{
    private int gastanksize;
    public int GasTankSize
    {
        get { return gastanksize; }
        set { gastanksize = value; }
    }
    public GasolineCar()
    {
        Type = "GasolineCar";
    }
}
class Dealership
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string location;
    public string Location
    {
        get { return location; }
        set { location = value; }
    }
    private List<Sale> ListofSale = new List<Sale>();
    public void AddSale(Sale sale)
    {
        for (int a = 0; a < ListofCar.Count; a++)
        {

            if (sale.Car.Make == ListofCar[a].Make && sale.Car.Model == ListofCar[a].Model)
            {
                ListofCar.Remove(ListofCar[a]);
                ListofSale.Add(sale);
            }
        }
    }
    public void PrintSales()
    {
        foreach (var sale in ListofSale)
        {
            Console.WriteLine("Customer Name: " + sale.CustomerName);
            Console.WriteLine("Customer Car Make: " + sale.Car.Make);
            Console.WriteLine("Customer Car Model: " + sale.Car.Model);
            Console.WriteLine("Customer Price Paid: " + sale.PricePaid);
        }
    }
    private List<Car> ListofCar = new List<Car>();
    public void AddCar(Car car)
    {
        ListofCar.Add(car);
    }
    public void RemoveCar(string carMake, string carModel)
    {
        Car x = new Car();
        foreach (var Car in ListofCar)
        {
            if (Car.Make.Equals(carMake))
            {
                x = Car;
            }
        }
        ListofCar.Remove(x);
        Car y = new Car();
        foreach (var Car in ListofCar)
        {
            if (Car.Model.Equals(carModel))
            {
                y = Car;
            }
        }
        ListofCar.Remove(y);
    }
    public void PrintCars()
    {
        foreach (var car in ListofCar)
        {
            Console.WriteLine("Car Make: " + car.Make);
            Console.WriteLine("Car Model: " + car.Model);
            Console.WriteLine("Car Year: " + car.Year);
            Console.WriteLine("Car Price: " + car.Price);
            Console.WriteLine("Car Type: " + car.Type);
        }
    }
}

class Sale
{
    private string customername;
    public string CustomerName
    {
        get { return customername; }
        set { customername = value; }
    }
    private Car car = new Car();
    public Car Car
    {
        get { return car; }
        set { car = value; }
    }
    private double pricepaid;
    public double PricePaid
    {
        get { return pricepaid; }
        set { pricepaid = value; }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Dealership dealership = new Dealership();
        Console.WriteLine("Dealership Name: ");
        dealership.Name = Console.ReadLine();
        Console.WriteLine("Dealership Location: ");
        dealership.Location = Console.ReadLine();
        while (true)
        {
            Console.WriteLine("1. Add Car");
            Console.WriteLine("2. Remove Car");
            Console.WriteLine("3. Print All Cars");
            Console.WriteLine("4. Make Sales");
            Console.WriteLine("5. Print Sales");
            Console.WriteLine("6. Exit");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Choose Menu: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("1. Hybrid Car");
                Console.WriteLine("2. Electric Car");
                Console.WriteLine("3. Gasolin Car");
                Console.WriteLine("-------------------------");
                string choice2 = Console.ReadLine();
                if (choice2 == "1")
                {
                    HybridCar hybridCar = new HybridCar();
                    Console.WriteLine("Input Car Make: ");
                    hybridCar.Make = Console.ReadLine();
                    Console.WriteLine("Input Car Model: ");
                    hybridCar.Model = Console.ReadLine();
                    Console.WriteLine("Input Car Year: ");
                    hybridCar.Year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Car Price: ");
                    hybridCar.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input Car Gas Tank Capacity: ");
                    hybridCar.GasTankSize = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Car Battery Capacity: ");
                    hybridCar.BatteryCapacity = Convert.ToInt32(Console.ReadLine());
                    dealership.AddCar(hybridCar);
                }
                if (choice2 == "2")
                {
                    ElectricCar electricCar = new ElectricCar();
                    Console.WriteLine("Input Car Make: ");
                    electricCar.Make = Console.ReadLine();
                    Console.WriteLine("Input Car Model: ");
                    electricCar.Model = Console.ReadLine();
                    Console.WriteLine("Input Car Year");
                    electricCar.Year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Car Price");
                    electricCar.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input Car Battery Capacity");
                    electricCar.BatteryCapacity = Convert.ToInt32(Console.ReadLine());
                    dealership.AddCar(electricCar);
                }
                if (choice2 == "3")
                {
                    GasolineCar gasolineCar = new GasolineCar();
                    Console.WriteLine("Input Car Make: ");
                    gasolineCar.Make = Console.ReadLine();
                    Console.WriteLine("Input Car Model: ");
                    gasolineCar.Model = Console.ReadLine();
                    Console.WriteLine("Input Car Year");
                    gasolineCar.Year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Car Price");
                    gasolineCar.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input Car Gas Tank Capacity");
                    gasolineCar.GasTankSize = Convert.ToInt32(Console.ReadLine());
                    dealership.AddCar(gasolineCar);
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Car Make: ");
                string delete = Console.ReadLine();
                Console.WriteLine("Car Model: ");
                string delete2 = Console.ReadLine();
                dealership.RemoveCar(delete, delete2);
            }
            else if (choice == "3")
            {
                dealership.PrintCars();
            }
            else if (choice == "4")
            {
                Sale customerName = new Sale();
                Console.WriteLine("Customer Name: ");
                customerName.CustomerName = Console.ReadLine();
                Console.WriteLine("Customer Car Make: ");
                customerName.Car.Make = Console.ReadLine();
                Console.WriteLine("Customer Car Model: ");
                customerName.Car.Model = Console.ReadLine();
                Console.WriteLine("Customer Price Paid: ");
                customerName.PricePaid = Convert.ToDouble(Console.ReadLine());
                dealership.AddSale(customerName);
            }
            else if (choice == "5")
            {
                dealership.PrintSales();
            }
            else if (choice == "6")
            {
                Environment.Exit(0);
            }
        }
    }
}