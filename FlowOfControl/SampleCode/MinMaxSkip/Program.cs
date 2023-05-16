int min, max, skip;

do
{
    Console.Write("Enter loop start: ");
    if(int.TryParse(Console.ReadLine(), out min))
    {
        break;
    }

    Console.WriteLine("That is not a valid int.");
} while (true);

do
{
    Console.Write("Enter loop end: ");
    if (int.TryParse(Console.ReadLine(), out max))
    {
        break;
    }

    Console.WriteLine("That is not a valid int.");
} while (true);

do
{
    Console.Write("Enter loop increment: ");
    if (int.TryParse(Console.ReadLine(), out skip))
    {
        break;
    }

    Console.WriteLine("That is not a valid int.");
} while (true);

for (int i = min; i <= max; i+=skip)
{
    Console.WriteLine(i);
}