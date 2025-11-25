class Program
{
    static void Main(string[] args)
    {
       
        Car car = new Car();
        car.Brand = "BMW";
        car.Speed = 120;
        car.Seats = 5;

        
        Motorcycle bike = new Motorcycle();
        bike.Brand = "Yamaha";
        bike.Speed = 90;
        bike.HasCarrier = true;

        
        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        bike.Start();
        bike.DisplayInfo();
        bike.Stop();
    }
}