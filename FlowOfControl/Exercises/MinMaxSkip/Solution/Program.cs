int init, condition, increment;

do
{
    Console.Write("Enter loop start: ");
    if(int.TryParse(Console.ReadLine(), out init))
    {
        break;
    }

    Console.WriteLine("That is not a valid int.");
} while (true);

do
{
    Console.Write("Enter loop increment: ");
    if (int.TryParse(Console.ReadLine(), out increment))
    {
        break;
    }

    Console.WriteLine("That is not a valid int.");
} while (true);

do
{
    Console.Write("Enter loop end: ");
    if (int.TryParse(Console.ReadLine(), out condition))
    {
        if (increment < 0 && condition < init)
        {
            break;
        }
        else if (increment > 0 && condition > init)
        {
            break;
        }
        else
        {
            Console.WriteLine("The condition must be less than init if increment is negative or greater than init if increment is positive.");
        }
    }

    Console.WriteLine("That is not a valid int.");
} while (true);


if(increment > 0)
{
    for (int i = init; i <= condition; i += increment)
    {
        Console.WriteLine(i);
    }
}
else
{
    for (int i = init; i >= condition; i += increment)
    {
        Console.WriteLine(i);
    }
}
