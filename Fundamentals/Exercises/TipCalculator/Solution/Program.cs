decimal amount, tip;

Console.WriteLine("Tip Calculator");
Console.WriteLine("==============");

Console.Write("Enter amount: ");
amount = decimal.Parse(Console.ReadLine());

Console.Write("Enter tip %: ");
tip = decimal.Parse(Console.ReadLine());

Console.Clear();
Console.Write($"A {tip:p0} tip on {amount:c} is ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{(tip * amount):c}");
Console.ResetColor();