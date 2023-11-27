// Goal: Roll dice 100 times, then print statistics (count, %)

// Declare array to hold 11 integers (2 to 12)
int[] rolls = new int[11];

// Create Random object to roll die
Random rng = new Random();

// Loop 100 times
for (int i = 0; i < 100; i++)
{
    // Add one to array slot 2 less than dice roll (array is 0 to 10)
    // rolls[rng.Next(1, 7) + rng.Next(1, 7) - 2]++;
    int index = rng.Next(1, 7) + rng.Next(1, 7) - 2;
    rolls[index]++;
}

// Loop Array from 0 to Length
for (int i = 0; i < rolls.Length; i++)
{
    // Print index + 2 as dice roll, element as count, and element / 100M as percent
    Console.WriteLine($"{i + 2}\t{rolls[i]}\t{(rolls[i] / 100M):p0}");
}


