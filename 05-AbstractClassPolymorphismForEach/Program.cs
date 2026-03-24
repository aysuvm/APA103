using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Cars
        Car car1 = new Car("Mercedes", "E200", 2023, "10-AA-001", 4, 500, true, 220);
        Car car2 = new Car("BMW", "320i", 2022, "10-BB-002", 4, 480, true, 235);
        Car car3 = new Car("Toyota", "Camry", 2021, "10-CC-003", 4, 524, true, 210);

        // Motorcycles
        Motorcycle m1 = new Motorcycle("Yamaha", "R1", 2023, "10-DD-004", 998, false, 299, "Sport");
        Motorcycle m2 = new Motorcycle("Harley-Davidson", "Cruiser", 2022, "10-EE-005", 1868, true, 180, "Cruiser");

        // Trucks
        Truck t1 = new Truck("MAN", "TGX", 2020, "10-FF-006", 18, 3, 12, 120);
        Truck t2 = new Truck("Volvo", "FH16", 2021, "10-GG-007", 25, 4, 18, 110);

        Console.WriteLine(" Cars");
        car1.ShowCarInfo();
        Console.WriteLine("Fuel cost (500 km): " + car1.CalculateFuelCost(500));

        car2.ShowCarInfo();
        Console.WriteLine("Fuel cost (500 km): " + car2.CalculateFuelCost(500));

        car3.ShowCarInfo();
        Console.WriteLine("Fuel cost (500 km): " + car3.CalculateFuelCost(500));

        Console.WriteLine("Motorcycles");
        m1.ShowMotorcycleInfo();
        Console.WriteLine("Fuel cost (300 km): " + m1.CalculateFuelCost(300));

        m2.ShowMotorcycleInfo();
        Console.WriteLine("Fuel cost (300 km): " + m2.CalculateFuelCost(300));

        Console.WriteLine(" Trucks );
        t1.ShowTruckInfo();
        Console.WriteLine("Fuel cost (800 km): " + t1.CalculateFuelCost(800));

        t2.ShowTruckInfo();
        Console.WriteLine("Fuel cost (800 km): " + t2.CalculateFuelCost(800));

      
        Console.WriteLine("oading Cargo ");
        t1.LoadCargo(5);
        Console.WriteLine("New fuel cost (800 km): " + t1.CalculateFuelCost(800));

   
        int totalVehicles = 7;

        double avgSpeed = (car1.MaxSpeed + car2.MaxSpeed + car3.MaxSpeed +
                           m1.MaxSpeed + m2.MaxSpeed +
                           t1.MaxSpeed + t2.MaxSpeed) / (double)totalVehicles;

        double maxFuelCost = Math.Max(
            Math.Max(car1.CalculateFuelCost(500), car2.CalculateFuelCost(500)),
            Math.Max(car3.CalculateFuelCost(500),
            Math.Max(m1.CalculateFuelCost(300),
            Math.Max(m2.CalculateFuelCost(300),
            Math.Max(t1.CalculateFuelCost(800), t2.CalculateFuelCost(800))))))
        );

        Console.WriteLine("Statistics");
        Console.WriteLine("Total vehicles: " + totalVehicles);
        Console.WriteLine("Average max speed: " + avgSpeed);
        Console.WriteLine("Most expensive fuel cost: " + maxFuelCost);
    }
}
