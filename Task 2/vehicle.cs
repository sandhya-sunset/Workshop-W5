
public class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public void Start()
    {
        Console.WriteLine($"{Brand} is starting...");
    }

    public void Stop()
    {
        Console.WriteLine($"{Brand} is stopping...");
    }

   
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}


public class Car : Vehicle
{
    public int Seats { get; set; }  

    public override void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Seats: {Seats}");
    }
}


public class Motorcycle : Vehicle
{
    public bool HasCarrier { get; set; }  

    public override void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Carrier: {HasCarrier}");
    }
}