// declare length and width variables
decimal length, width;

// prompt for length
Console.Write("Enter length: ");
length = decimal.Parse(Console.ReadLine());

// prompt for width
Console.Write("Enter width: ");
width = decimal.Parse(Console.ReadLine());

// output area to console
Console.WriteLine("The area of the rectangle is " + (length * width).ToString());