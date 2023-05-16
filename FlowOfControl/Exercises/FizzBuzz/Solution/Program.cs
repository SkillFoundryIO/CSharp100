for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

// option 2, no mod operator usage
int a=0, b=0;
for (int i = 1; i <= 100; i++)
{
    a++;
    b++;

    if (a==3 && b==5)
    {
        Console.WriteLine("fizzbuzz");
        a = 0;
        b = 0;
    }
    else if (a==3)
    {
        Console.WriteLine("fizz");
        a = 0;
    }
    else if (b==5)
    {
        Console.WriteLine("buzz");
        b = 0;
    }
    else
    {
        Console.WriteLine(i);
    }
}