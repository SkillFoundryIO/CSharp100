/*
	1. Declare Variables - Random rng, int first, int second, string guess
	2. Assign first and second to random between 1 and 10
	3. Output the first number
	4. Prompt user whether the second number will be higher, lower, or equal.
	   a. To simplify, we will ask them for H, L, or E.
	5. Store user input in guess.
	6. Clear the console.
	7. Output the values of first and second.
	8. if guess is higher
	   a. if first is less than second print right message.
	   b. else print wrong message
	9. if guess is lower
	   a. if first is greater than second print right message.
	   b. else print wrong message
   10. if guess is equal
       a. if first is equal to second print right message.
       b. else print wrong message
   11. Otherwise print invalid message
*/

int first, second;
string guess;

Random rng = new Random();

first = rng.Next(1, 11);
second = rng.Next(1, 11);

Console.WriteLine($"The first number is {first}.");

Console.Write("Will the second number be (H)igher, (L)ower, or (E)qual: ");
guess = Console.ReadLine().ToUpper();
Console.Clear();

Console.WriteLine($"The numbers were [{first}, {second}]");

if (guess == "H")
{
    if(first < second)
    {
        Console.WriteLine("You guessed higher and you were right!");
    }
    else
    {
        Console.WriteLine("You guessed higher and you were wrong!");
    }  
}
else if (guess == "L")
{
    if (first > second)
    {
        Console.WriteLine("You guessed lower and you were right!");
    }
    else
    {
        Console.WriteLine("You guessed lower and you were wrong!");
    }
}
else if (guess == "E")
{
    if (first == second)
    {
        Console.WriteLine("You guessed equal and you were right!");
    }
    else
    {
        Console.WriteLine("You guessed equal and you were wrong!");
    }
}
else
{
    Console.WriteLine("That wasn't a valid guess. Game over.");
}

