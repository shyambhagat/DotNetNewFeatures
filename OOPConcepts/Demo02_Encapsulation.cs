namespace OOPConcepts;

internal static class Demo02_Encapsulation
{
    public static void RunDemo()
    {
        var account = new BankAccount("12345", 1000);
        account.Deposit(500);
        account.Withdraw(200);
        Console.WriteLine($"Account Balance: {account.GetBalance()}");
    }

    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        private decimal Balance;

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
        }

        public decimal GetBalance() => Balance;
    }
}
