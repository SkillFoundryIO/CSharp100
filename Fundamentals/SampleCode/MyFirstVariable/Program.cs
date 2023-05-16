// Double backslash makes a single line comment

/*
 * This is a multiple
 * line
 * comment
*/

// Declare a string variable to store the name
string firstName;

/*         Rules for variable identifiers
 * 1. They must start with a character [a-Z] or an underscore [_]
 * 2. They can contain numbers, but not on the first character: 1street is invalid. street1 is valid
 * 3. They must be unique in the same code block. (we will learn about blocks later)
 * 4. They can start with the @ character if you want to use a keyword as an identifier. 
 *    For example: @string myVariable;  AVOID DOING THIS!!!
 * 5. Some languages use _ between words like first_name but C# developers prefer camel casing: firstName
*/

// Prompt the user to enter their name.
Console.Write("Enter your name: ");

// Get the name from the console and assign (store) it to the variable
firstName = Console.ReadLine();

// Write "Hello, Name" to the Console using WriteLine()
Console.WriteLine("Hello, " + firstName);