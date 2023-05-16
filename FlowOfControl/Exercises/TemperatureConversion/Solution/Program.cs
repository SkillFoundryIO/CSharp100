double temperature, conversion;
string unit1, unit2;

Console.WriteLine("Welcome to Temperature Conversion!");
Console.WriteLine("==================================");
Console.WriteLine("Available units are (C)elcius, (F)ahrenheit, and (K)elvin.\n");

Console.Write("Enter Temperature: ");
temperature = double.Parse(Console.ReadLine());

Console.Write("Enter Unit: ");
unit1 = Console.ReadLine().ToUpper();

Console.Write("Enter Conversion Unit: ");
unit2 = Console.ReadLine().ToUpper();

Console.WriteLine(); // blank line

if(unit1 == "C")
{
    if (unit2 == "F")
    {
        conversion = Math.Round(temperature * 9 / 5 + 32, 2);
        Console.WriteLine($"A temperature of {temperature}{unit1} is {conversion}{unit2}.");
    }
    else if (unit2 == "K")
    {
        conversion = Math.Round(temperature + 273.15, 2);
        Console.WriteLine($"A temperature of {temperature}{unit1} is {conversion}{unit2}.");
    }
    else if (unit2 == "C")
    {
        Console.WriteLine($"We cannot convert {unit1} to {unit2}!");
    }
    else
    {
        Console.WriteLine($"The unit {unit2} is not valid!");
    }
}
else if(unit1 == "F")
{
    if (unit2 == "F")
    {
        Console.WriteLine($"We cannot convert {unit1} to {unit2}!");
    }
    else if (unit2 == "K")
    {
        conversion = Math.Round(((temperature - 32) * 5 / 9) + 273.15, 2);
        Console.WriteLine($"A temperature of {temperature}{unit1} is {conversion}{unit2}.");
    }
    else if (unit2 == "C")
    {
        conversion = Math.Round((temperature - 32) * 5 / 9, 2);
        Console.WriteLine($"A temperature of {temperature}{unit1} is {conversion}{unit2}.");
    }
    else
    {
        Console.WriteLine($"The unit {unit2} is not valid!");
    }
}
else if(unit1 == "K")
{
    if (unit2 == "F")
    {
        conversion = Math.Round((temperature - 273.15) * 9 / 5 + 32, 2);
        Console.WriteLine($"A temperature of {temperature}{unit1} is {conversion}{unit2}.");
    }
    else if (unit2 == "K")
    {
        Console.WriteLine($"We cannot convert {unit1} to {unit2}!");
    }
    else if (unit2 == "C")
    {
        conversion = Math.Round(temperature - 273.15, 2);
        Console.WriteLine($"A temperature of {temperature}{unit1} is {conversion}{unit2}.");
    }
    else
    {
        Console.WriteLine($"The unit {unit2} is not valid!");
    }
}
else
{
    Console.WriteLine($"The unit {unit1} is not valid!");
}