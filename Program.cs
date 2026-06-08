// clear the console
Console.Clear();

// basic user menu with abilitiy to "Exit"
string ExitCommand = "Exit";
while(true)
{
    Console.WriteLine("Hello");
    string input = Console.ReadLine();

    Console.WriteLine("Name:" + input);

    if (input == ExitCommand)
        {
            break;
        }
}

Console.WriteLine("Program exit");
