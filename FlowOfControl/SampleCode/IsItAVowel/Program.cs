string key;

Console.Write("Press any Key: ");
key = Console.ReadLine().ToUpper();

if (key == "A" || key == "E" || key == "I" || key == "O" || key == "U")
{
    Console.WriteLine("It's a vowel");
}
else if (key == "Y")
{
    Console.WriteLine("Sometimes a vowel");
}
else
{
    Console.WriteLine("Not a vowel");
}

switch (key)
{
    case "A":
    case "E":
    case "I":
    case "O":
    case "U":
        Console.WriteLine("It's a vowel");
        break;
    case "Y":
        Console.WriteLine("Sometimes a vowel");
        break;
    default:
        Console.WriteLine("Not a vowel");
        break;
}