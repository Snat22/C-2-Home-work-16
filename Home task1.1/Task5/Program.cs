using Task5;

var card1 = new PaymentCard(1000.0m);
System.Console.WriteLine($"Balance: {card1.GetBalance()}");
card1.TakeMoney(200);
System.Console.WriteLine($"Balance: {card1.GetBalance()}");
card1.AddMoney(10);
System.Console.WriteLine($"Balance: {card1.GetBalance()}");


var card2 = new PaymentCard(1000.0m);
System.Console.WriteLine($"Balance card2 : {card2.GetBalance()}");
card2.TakeMoney(200);
System.Console.WriteLine($"Balance card2 : {card2.GetBalance()}");
card2.AddMoney(10);
System.Console.WriteLine($"Balance card2 : {card2.GetBalance()}");


var cash = new PaymentTerminal();
cash.AddMoneyToCard(card1,1000.0m);
System.Console.WriteLine($"Balance: {card1.GetBalance()}");

cash.PayWithCard(card2,300);
System.Console.WriteLine($"Balance card2 : {card2.GetBalance()}");

cash.PayWithCash(100);

System.Console.WriteLine($"Balance: {card1.GetBalance()}");

