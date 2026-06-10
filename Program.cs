
class TimeMenu
{
    
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

    public void ShowCurrentTime()
    {
        ShowResult("Current Time: " +  DateTime.Now.ToString("HH:mm"));
    }

    public void ShowCurrentDay()
    {
        ShowResult("Current Day: "+ DateTime.Now.DayOfWeek);
    }

    public void ShowCurrentMonth()
    {
        ShowResult("Current Month: " + DateTime.Now.ToString("MMMM"));
    }

    public void ShowHoursLeftOfDay()
    {
        int HoursLeft = 24 - DateTime.Now.Hour;
        ShowResult("Hours left of today: " +  HoursLeft);
    }

    public void ShowDaysLeftOfMonth()
    {
        DateTime now = DateTime.Now;

        int daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
        int daysLeft = daysInMonth - now.Day;

        ShowResult("Days left of this month: " + daysLeft);
    }

    public void ShowDaysLeftOfYear()
    {
        DateTime now = DateTime.Now;

        DateTime lastDayOfYear = new DateTime(now.Year, 12,31);
        int daysLeft = (lastDayOfYear - now).Days;

        ShowResult("Days left of this year: " + daysLeft);
    }

    public void ShowAllpage1()
    {
        ShowCurrentTime();
        ShowCurrentDay();
        ShowCurrentMonth();
    }

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


            if (page == 1)
            {
                Console.WriteLine("==== Curent Time Menu ====");
                Console.WriteLine();
                Console.WriteLine("1. Show Current Time");
                Console.WriteLine("2. Show Current Day");
                Console.WriteLine("3. Show Current Month");
                Console.WriteLine("4. Show All");
                Console.WriteLine("5. Next Page");
                Console.WriteLine("6. Exit Program");
            }

            else
            {
                Console.WriteLine("==== Time Left Menu ====");
                Console.WriteLine();
                Console.WriteLine("1. Show Hours Left Of Day");
                Console.WriteLine("2. Show Days Left Of Month");
                Console.WriteLine("3. Show Days Left Of Year");
                Console.WriteLine("4. Show All");
                Console.WriteLine("5. Previous Page");
                Console.WriteLine("6. Exit Program");
            }

            Console.WriteLine();
            Console.Write("Choose An Option To: ");


            char choice = Console.ReadKey().KeyChar;
            Console.Clear();


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
                    Console.WriteLine("Error code: 144");
            }

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
                    Console.WriteLine("Error Code: 168");
            }

            if (running)
            {
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }

        }

            Console.WriteLine("Exiting TimeCheck...");
            Console.WriteLine("");
            Console.WriteLine(" -- Localizing folder: System32");    
            Console.WriteLine("");

            Console.Write("Loading: 0%");

        for (int i = 0; i <= 100; i += 1)
        {
            await Task.Delay(150);

            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"Loading: {i}%   ");
        }

        Console.WriteLine();
        Console.WriteLine("Finished!");

        await Task.Delay(2500);

        Console.WriteLine("");
        Console.WriteLine("Localizing folder: System32 - Complete");
        await Task.Delay(2500);
        Console.WriteLine("");
        Console.WriteLine("-- Folder to delete: System32");
        await Task.Delay(5000);
        Console.WriteLine("");
        Console.WriteLine("-- Recover folder: system32 ");
        await Task.Delay(5000);
    }

}
