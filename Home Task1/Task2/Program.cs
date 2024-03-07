
using Task2;

var user1 = new Account("Heikki's",1000.0m);
user1.WithDraw(100);
System.Console.WriteLine(user1.Balance);
System.Console.WriteLine(user1.Tostring());
var user2 = new Account("Personal",0);
System.Console.WriteLine(user2.Balance);
user2.Deposit(100);
System.Console.WriteLine(user2.Tostring());

