// declare number to get factors from
int num;

// loop for prompt
do
{
    // prompt user for num > 1
    Console.Write("Enter a number greater than 1: ");

    // TryParse
    if (int.TryParse(Console.ReadLine(), out num))
    {
        // break if num > 1
        if (num > 1)
        {
            break;
        }

        Console.WriteLine("Invalid input");
    }
} while (true);

// print start of output line 'The factors of {num} are: 1, w, x, y, z, num'
Console.Write($"The factors of {num} are: ");

// loop from 1 to num / 2
for (int i = 1; i <= num / 2; i++)
{
    // print if loop variable mod num is 0
    if (num % i == 0)
    {
        Console.Write($"{i}, ");
    }
}

// print num, since 1 and num are always factors
Console.WriteLine(num);