string firstName = "Jane";
string lastName = "Doe";

int x = 1234;

decimal tax = .05M;
decimal amount = 105.42M;

DateTime today = DateTime.Now;

Console.WriteLine(today);

Console.WriteLine($"Name: {lastName}, {firstName}");

Console.WriteLine($"A {tax:p0} tax on {amount:c} is {(tax * amount):c}");

Console.WriteLine($"{x:D6}");

Console.WriteLine($"{x:N0}");

Console.WriteLine($"{today:d}");
Console.WriteLine($"{today:dddd MMM d, yyyy}");
Console.WriteLine($"{today:HH:mm:ss}");