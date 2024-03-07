using Task4;

var cnt = new Counter();
cnt.Value = 10;
cnt.Increase();
System.Console.WriteLine(cnt.Value);
cnt.Increase(10);
System.Console.WriteLine(cnt.Value);
cnt.Decrease();
cnt.Decrease(11);
System.Console.WriteLine(cnt.Value);
