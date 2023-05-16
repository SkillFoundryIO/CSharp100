string input, output = "";

Console.Write("Enter a string: ");
input = Console.ReadLine();

for (int i = input.Length - 1; i>=0; i--)
{
    output += input[i];
}

Console.WriteLine($"Reversed is {output}");