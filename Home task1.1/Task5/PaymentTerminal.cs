namespace Task5;

public class PaymentTerminal
{
    decimal _money;
    public PaymentTerminal()
    {
        _money = 0;
    }

    public void AddMoneyToCard(PaymentCard card,decimal amount)
    {
        if (amount > 0)
        {
            card.AddMoney(amount);
            _money += amount;
        }
    }

    public void PayWithCard(PaymentCard card,decimal amount)
    {
        if (amount > 0 && card.GetBalance() >= amount)
        {
            card.TakeMoney(amount);
            _money -= amount;
        }
    }

    public void PayWithCash(decimal amount)
    {
        if (amount > 0 && _money>= amount)
        {
            _money -= amount;
        }
    }
}
