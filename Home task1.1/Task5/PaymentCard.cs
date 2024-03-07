namespace Task5;

public class PaymentCard
{
    decimal _balance;
    public PaymentCard(decimal balance)
    {
        _balance = balance;
    }
    public decimal GetBalance()
    {
        return _balance;
    }

    public void AddMoney(decimal amount)
    {
if (amount > 0)
{
    _balance+= amount;
}
    }

    public void TakeMoney(decimal amount)
    {
        if (amount > 0 && _balance >= amount)
        {
            _balance -= amount;
        }
    }
}
