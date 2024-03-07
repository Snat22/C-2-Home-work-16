namespace Task2;

public class Account
{
    public string Name { get; set; }

    public decimal Balance { get; private set; }

    public Account(string name,decimal balance)
    {
        Name = name;
        Balance = balance;
    }

    public void WithDraw(decimal amount)
    {
        Balance -= amount;
    }

    public void Deposit(decimal amount)
    {
        Balance+= amount;
    }

    public string Tostring()
    {
         return $"{Name} account balance: {Balance}";
    }
}
