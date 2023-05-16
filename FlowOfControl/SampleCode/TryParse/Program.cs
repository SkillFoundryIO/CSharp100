string input;

int num;
double val;

do
{
    Console.Write("Enter an value: ");
    input = Console.ReadLine();
    //    true/false   string, converted value output
    if(double.TryParse(input, out val))
    {
        break;
    }

    Console.WriteLine("That is not a valid value!");
} while (true);

do
{
    Console.Write("Enter a positive value: ");
    input = Console.ReadLine();

    if(int.TryParse(input, out num))
    {
        if (num > 0)
        {
            break;
        }
    }

    Console.WriteLine("That is not a valid value!");
} while (true);