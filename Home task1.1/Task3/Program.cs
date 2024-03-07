using Task3;

var s = new Gauge();
s.value = 6;
System.Console.WriteLine(s.Full());
s.Enhance();
s.Decrease();
System.Console.WriteLine(s.Full());
s.Enhance();
s.Decrease();
s.Decrease();
System.Console.WriteLine(s.Full());


