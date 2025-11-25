class Program
{
    static void Main(string[] args)
    {
       
        BankAccount account = new BankAccount("ACCOUNT123", 4000);

       
        Console.WriteLine("Account Number: " + account.AccountNumber);

        
        account.Deposit(2000);

        
        account.Withdraw(1500);

       
        Console.WriteLine("Remaining Balance: " + account.Balance);
    }
}