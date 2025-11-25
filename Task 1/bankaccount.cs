public class BankAccount
{
   
    private string accountNumber;
    private double balance;

   
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value <= 0)
            {
                Console.WriteLine("Balance cannot be zero or negative.");
            }
            else
            {
                balance = value;
            }
        }
    }

    public BankAccount(string accNum, double openingBalance)
    {
        accountNumber = accNum;
        Balance = openingBalance; 
    }

   
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than 0.");
        }
        else
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
    }

    
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be greater than 0.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance!");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
    }
}