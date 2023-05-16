Console.WriteLine("\t1\t2\t3\t4\t5");

for(int i=1; i<=5; i++)
{
    Console.Write($"{i}\t");
    for(int j=1; j<=5; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.WriteLine();
}