
class TimeMenu
{
    // Result box
    public void ShowResult(string text)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("=============================");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(text);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("=============================");
        Console.ResetColor();
        Console.WriteLine();
    }

    // Output = Current time
    public void ShowCurrentTime()
    {
        ShowResult("Current time: " +  DateTime.Now.ToString("HH:mm"));
    }

    // Output = Current day
    public void ShowCurrentDay()
    {
        ShowResult("Current day: "+ DateTime.Now.DayOfWeek);
    }

    // Output = Current month
    public void ShowCurrentMonth()
    {
        ShowResult("Current Month: " + DateTime.Now.ToString("MMMM"));
    }

    // Output = Hours left of day
    public void ShowHoursLeftOfDay()
    {
        int HoursLeft = 24 - DateTime.Now.Hour;
        ShowResult("Hours left of today: " +  HoursLeft);
    }

    // Output = Days left of month
    public void ShowDaysLeftOfMonth()
    {
        DateTime now = DateTime.Now;

        int daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
        int daysLeft = daysInMonth - now.Day;

        ShowResult("Days left of this month: " + daysLeft);
    }

    // Output = Days left of year
    public void ShowDaysLeftOfYear()
    {
        DateTime now = DateTime.Now;

        DateTime lastDayOfYear = new DateTime(now.Year, 12,31);
        int daysLeft = (lastDayOfYear - now).Days;

        ShowResult("Days left of this year: " + daysLeft);
    }

    // Page ( 1 ) Selections
    public void ShowAllpage1()
    {
        ShowCurrentTime();
        ShowCurrentDay();
        ShowCurrentMonth();
    }

    // Page ( 2 ) Selections
    public void ShowAllpage2()
    {
        ShowHoursLeftOfDay();
        ShowDaysLeftOfMonth();
        ShowDaysLeftOfYear();
    }
}

class MenuList
{
    static async Task Main()
    {
        TimeMenu menu = new TimeMenu();

        int page = 1;
    
        bool running = true;

        while (running)
        {
            Console.Clear();


            // Page ( 1 )
            if (page == 1)
            {   
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("==== Current time menu ====");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("1. Show current time");
                Console.WriteLine("2. Show current day");
                Console.WriteLine("3. Show current month");
                Console.WriteLine("4. Show all");
                Console.WriteLine("5. Next page");
                Console.WriteLine("6. Exit program");
            }


            // Page ( 2 )
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("==== Time left menu ====");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("1. Show hours left of day");
                Console.WriteLine("2. Show days left of month");
                Console.WriteLine("3. Show days left of year");
                Console.WriteLine("4. Show all");
                Console.WriteLine("5. Previous page");
                Console.WriteLine("6. Exit program");
            }

            // Give user ( Hint )
            Console.WriteLine();
            Console.Write("Choose an option to: ");


            char choice = Console.ReadKey().KeyChar;
            Console.Clear();


            // Page: ( 1 )
            if (page == 1) 
            {
                if (choice == '1')
                    menu.ShowCurrentTime();

                else if (choice == '2')
                    menu.ShowCurrentDay();

                else if (choice == '3')
                    menu.ShowCurrentMonth();

                else if (choice == '4')
                    menu.ShowAllpage1();

                else if (choice == '5')
                    page = 2;

                else if (choice == '6')
                    running = false;

                else
                    Console.WriteLine("Error code: 161");
            }

            // Page ( 2 )
            else 
            {
                if (choice == '1')
                    menu.ShowHoursLeftOfDay();
                
                else if (choice == '2')
                    menu.ShowDaysLeftOfMonth();

                else if (choice == '3')
                     menu.ShowDaysLeftOfYear();

                else if (choice == '4')
                    menu.ShowAllpage2();

                else if (choice == '5')
                    page = 1;

                else if (choice == '6')
                    running = false;

                else
                    Console.WriteLine("Error code: 186");
            }

            if (running)
            {
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }

        }

            // Loading Screen ( System32 )
            Console.WriteLine("Exiting TimeCheck...");
            Console.WriteLine("");
            Console.WriteLine(" -- Localizing folder: System32");    
            Console.WriteLine("");

            Console.Write("Loading: 0%");

        for (int i = 0; i <= 100; i += 1)
        {
            await Task.Delay(150);

            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"Searching: {i}%  C:\\Windows\\System32  ");
        }

        Console.WriteLine();
        Console.WriteLine("Localized folder: System32");

        await Task.Delay(2500);

        Console.WriteLine("");
        Console.WriteLine("-- Folder to delete: System32");
        await Task.Delay(7500);
        Console.WriteLine("");
        Console.WriteLine("-- Folder System32 deleted successfully.");
        await Task.Delay(5000);
    }

}

