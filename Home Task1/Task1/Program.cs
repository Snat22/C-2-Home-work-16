
using Task1;
try
{
var user1 = new Account();
System.Console.Write("Balance: ");
user1.Balance = 100m;
System.Console.WriteLine(user1.BalanceInfo());

System.Console.WriteLine();
System.Console.Write("Skolko vi xotite dobavit: ");
user1.AddBalance(Convert.ToDecimal(Console.ReadLine()));
System.Console.WriteLine(user1.BalanceInfo());
}
catch (System.Exception)
{
    
    System.Console.WriteLine("NE verniy vivod: ");
}