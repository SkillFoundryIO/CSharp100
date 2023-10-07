decimal triangleBase, triangleHeight;

// Prompt and store base
Console.Write("Enter triangle base: ");
triangleBase = decimal.Parse(Console.ReadLine());

// Prompt and store height
Console.Write("Enter triangle height: ");
triangleHeight = decimal.Parse(Console.ReadLine());

// Print area of rectangle
Console.WriteLine("The area of the triangle is: " + (0.5M * triangleBase * triangleHeight));