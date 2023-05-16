double radius, area;

Console.Write("Enter a radius: ");
radius = double.Parse(Console.ReadLine());

area = Math.PI * Math.Pow(radius, 2);

Console.WriteLine("A circle with radius " + radius + " has an area of " + area + ".");