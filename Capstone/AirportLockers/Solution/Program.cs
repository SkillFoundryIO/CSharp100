string[] lockers = new string[100];
int userChoice; // for menu options
int lockerNumber; // the locker number the user picks
int lockerIndex; // the array index of the locker number

while (true)
{
    Console.Clear();
    Console.WriteLine("Airport Locker Rental Menu");
    Console.WriteLine("=============================");
    Console.WriteLine("1. View a locker");
    Console.WriteLine("2. Rent a locker");
    Console.WriteLine("3. End a locker rental");
    Console.WriteLine("4. List all locker contents");
    Console.WriteLine("5. Quit");
    Console.Write("\nEnter your choice (1-5): ");

    // validated menu option picker
    do
    {
        if (int.TryParse(Console.ReadLine(), out userChoice))
        {
            if (userChoice >= 1 && userChoice <= 5)
            {
                break;
            }

            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
        }
    } while (true);

    // Quit
    if (userChoice == 5)
    {
        break;
    }

    // List all
    if (userChoice == 4)
    {
        for (int i = 0; i < lockers.Length; i++)
        {
            if (lockers[i] != null)
            {
                Console.WriteLine($"Locker {i + 1}: {lockers[i]}");
            }
        }
    }
    else
    {
        // we will need a locker number for options 1, 2, and 3, so doing it here lets us write the code only one time
        do
        {
            Console.Write("Enter locker number (1-100): ");
            if (int.TryParse(Console.ReadLine(), out lockerNumber))
            {
                if (lockerNumber >= 1 && lockerNumber <= 100)
                {
                    lockerIndex = lockerNumber - 1; // adjust for index
                    break;
                }

                Console.WriteLine("Invalid choice. Please enter a number between 1 and 100.");
            }
        } while (true);

        // View Locker
        if(userChoice == 1)
        {
            if (lockers[lockerIndex] == null)
            {
                Console.WriteLine($"Locker {lockerNumber} is EMPTY");
            }
            else
            {
                Console.WriteLine($"Locker {lockerNumber} contents: Laptop");
            }
        }
        else if (userChoice == 2) // Rent Locker
        {
            // is the locker already rented?
            if (lockers[lockerIndex] != null)
            {
                Console.WriteLine("Sorry, but locker 10 has already been rented!");
            }
            else
            {
                do
                {
                    Console.Write("Enter the item you want to store in the locker: ");
                    string item = Console.ReadLine();

                    if (!string.IsNullOrEmpty(item))
                    {
                        lockers[lockerIndex] = item;
                        Console.WriteLine($"Locker {lockerNumber} has been rented for {item} storage.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You must provide an item description.");
                    }
                } while (true);
            }
        }
        else // End locker rental
        {
            if (lockers[lockerIndex] == null)
            {
                Console.WriteLine($"Locker {lockerNumber} is not currently rented.");
            }
            else
            {
                Console.WriteLine($"Locker {lockerNumber} rental has ended, please take your {lockers[lockerIndex]}.");
                lockers[lockerIndex] = null;
            }
        }    
        
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}