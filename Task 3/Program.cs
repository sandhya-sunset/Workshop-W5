

class Program
{
    static void Main(string[] args)
    {
       
        Printer printer = new Printer();
        printer.Print("Hello Students");
        printer.Print(25);
        printer.Print("Repeat This", 3);

        Console.WriteLine("\n--- Teacher Classes ---");

        
        NepaliTeacher nepali = new NepaliTeacher();
        nepali.Name = "Sandhya";
        Console.WriteLine("Teacher Name: " + nepali.Name);
        nepali.Teaching();     
        nepali.SalaryInfo();   

        Console.WriteLine();

       
        EnglishTeacher english = new EnglishTeacher();
        english.Name = "Suvekshya";
        Console.WriteLine("Teacher Name: " + english.Name);
        english.Teaching();    
        english.SalaryInfo();  
    }
}