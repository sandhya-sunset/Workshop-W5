

class Program
{
    static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        
        Laptop laptop1 = new Laptop("Asus", 1200);
        Smartphone phone1 = new Smartphone("Samsung", 800);

        
        store.AddDevice(laptop1);
        store.AddDevice(phone1);

       
        store.ShowAllDeviceDetails();
    }
}