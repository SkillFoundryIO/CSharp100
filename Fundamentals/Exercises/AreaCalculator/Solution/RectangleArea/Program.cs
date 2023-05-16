int length, width;

Console.Write("Enter Length: ");
length = int.Parse(Console.ReadLine());

Console.Write("Enter Width: ");
width = int.Parse(Console.ReadLine());

Console.WriteLine("A rectangle with dimensions " + length + "x" + width + " has an area of " + length*width + ".");