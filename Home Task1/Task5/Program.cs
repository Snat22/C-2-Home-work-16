
using Task5;

var val1 = new Counter(9);
System.Console.WriteLine(val1.PrintValue());
val1.Decrement();
val1.Decrement();
System.Console.WriteLine(val1.PrintValue());
val1.Reset();
System.Console.WriteLine(val1.PrintValue());
