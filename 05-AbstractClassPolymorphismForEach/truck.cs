class Truck : Vehicle
{
    public double CargoCapacity;
    public int AxleCount;
    public double CurrentLoad;
    public int MaxSpeed;

    public Truck(string brand, string model, int year, string plateNumber,
                 double cargoCapacity, int axleCount, double currentLoad, int maxSpeed)
        : base(brand, model, year, plateNumber)
    {
        this.CargoCapacity = cargoCapacity;
        this.AxleCount = axleCount;
        this.CurrentLoad = currentLoad;
        this.MaxSpeed = maxSpeed;
    }

    public void ShowTruckInfo()
    {
        ShowBasicInfo();
        Console.WriteLine($"Capacity: {CargoCapacity} ton, Axles: {AxleCount}, Load: {CurrentLoad} ton, MaxSpeed: {MaxSpeed}");
    }

    public void LoadCargo(double weight)
    {
        if (CurrentLoad + weight <= CargoCapacity)
        {
            CurrentLoad += weight;
            Console.WriteLine($"Loaded {weight} ton. Current load: {CurrentLoad}");
        }
        else
        {
            Console.WriteLine("Capacity exceeded!");
        }
    }

    public double CalculateFuelCost(double distance)
    {
        return (distance / 100) * (25 + CurrentLoad * 2) * 1.80;
    }
}