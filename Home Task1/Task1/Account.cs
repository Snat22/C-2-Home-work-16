namespace Task1;

public class Account
{
    public decimal Balance { get; set; } 

    public void AddBalance(decimal amount)
    {
        Balance += amount;
    }

    public decimal BalanceInfo()
    {
        return Balance;
    }
}
