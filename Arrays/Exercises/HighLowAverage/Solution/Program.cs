int length;
Random rng = new Random();
// preset low and high to max/min
int low = 1000, high = -1000;
double sum=0;
int[] numbers;

do
{
    Console.Write("How many numbers: ");
    if (int.TryParse(Console.ReadLine(), out length))
    {
        if (length > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Numbers must be positive.");
        }
    }
    else
    {
        Console.WriteLine("That is not a valid number.");
    }
} while (true);

numbers = new int[length];


for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rng.Next(-1000, 1001);

    if(numbers[i] < low)
    {
        low = numbers[i];
    }

    if(numbers[i] > high)
    {
        high = numbers[i];
    }

    sum += numbers[i];
}

Console.WriteLine($"Total Numbers: {numbers.Length}");
Console.WriteLine($"Low: {low}");
Console.WriteLine($"High: {high}");
Console.WriteLine($"Average: {Math.Round(sum / numbers.Length, 2)}");