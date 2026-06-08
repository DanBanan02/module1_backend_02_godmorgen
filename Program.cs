// clear the console
Console.Clear();

// basic user menu with abilitiy to "Exit"
string ExitCommand = "exit";
while(true)
{
    Console.WriteLine("Hello");
    string input = Console.ReadLine();

    Console.WriteLine("Name:" + input);

    if (input.ToLower() == ExitCommand)
        {
            break;
        }
}

Console.WriteLine("Program exit");
