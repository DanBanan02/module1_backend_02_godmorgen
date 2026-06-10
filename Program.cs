
class TimeMenu
{
    
    public void ShowResult(string text)
    {
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("=============================");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(text);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
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
        int HoursLeft = 23 - DateTime.Now.Hour;
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
                    Console.WriteLine("Error code: 142");
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
                    Console.WriteLine("Error Code: 166");
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

        // Waste of Space...
        // Made before foreach fix update...

  /*    Console.WriteLine("1%");
        await Task.Delay(500);;
        Console.WriteLine("2%");
        await Task.Delay(500);
        Console.WriteLine("3%");
        await Task.Delay(500);
        Console.WriteLine("4%");
        await Task.Delay(500);
        Console.WriteLine("5%");
        await Task.Delay(500);
        Console.WriteLine("6%");
        await Task.Delay(500);
        Console.WriteLine("7%");
        await Task.Delay(500);
        Console.WriteLine("8%");
        await Task.Delay(500);
        Console.WriteLine("9%");
        await Task.Delay(500);
        Console.WriteLine("10%");
        await Task.Delay(500);
        Console.WriteLine("11%");
        await Task.Delay(500);
        Console.WriteLine("12%");
        await Task.Delay(500);
        Console.WriteLine("13%");
        await Task.Delay(500);
        Console.WriteLine("14%");
        await Task.Delay(500);
        Console.WriteLine("15%");
        await Task.Delay(500);
        Console.WriteLine("16%");
        await Task.Delay(500);
        Console.WriteLine("17%");
        await Task.Delay(500);
        Console.WriteLine("18%");
        await Task.Delay(500);
        Console.WriteLine("19%");
        await Task.Delay(500);
        Console.WriteLine("20%");
        await Task.Delay(500);
        Console.WriteLine("21%");
        await Task.Delay(500);
        Console.WriteLine("22%");
        await Task.Delay(500);
        Console.WriteLine("23%");
        await Task.Delay(500);
        Console.WriteLine("24%");
        await Task.Delay(500);
        Console.WriteLine("25%");
        await Task.Delay(500);
        Console.WriteLine("26%");
        await Task.Delay(500);
        Console.WriteLine("27%");
        await Task.Delay(500);
        Console.WriteLine("28%");
        await Task.Delay(500);
        Console.WriteLine("29%");
        await Task.Delay(500);
        Console.WriteLine("30%");
        await Task.Delay(500);
        Console.WriteLine("31%");
        await Task.Delay(500);
        Console.WriteLine("32%");
        await Task.Delay(500);
        Console.WriteLine("33%");
        await Task.Delay(500);
        Console.WriteLine("34%");
        await Task.Delay(500);
        Console.WriteLine("35%");
        await Task.Delay(500);
        Console.WriteLine("36%");
        await Task.Delay(500);
        Console.WriteLine("37%");
        await Task.Delay(500);
        Console.WriteLine("38%");
        await Task.Delay(500);
        Console.WriteLine("39%");
        await Task.Delay(500);
        Console.WriteLine("40%");
        await Task.Delay(500);
        Console.WriteLine("41%");
        await Task.Delay(500);
        Console.WriteLine("42%");
        await Task.Delay(500);
        Console.WriteLine("43%");
        await Task.Delay(500);
        Console.WriteLine("44%");
        await Task.Delay(500);
        Console.WriteLine("45%");
        await Task.Delay(500);
        Console.WriteLine("46%");
        await Task.Delay(500);
        Console.WriteLine("47%");
        await Task.Delay(500);
        Console.WriteLine("48%");
        await Task.Delay(500);
        Console.WriteLine("49%");
        await Task.Delay(500);
        Console.WriteLine("50%");
        await Task.Delay(500);
        Console.WriteLine("51%");
        await Task.Delay(500);
        Console.WriteLine("52%");
        await Task.Delay(500);
        Console.WriteLine("53%");
        await Task.Delay(500);
        Console.WriteLine("54%");
        await Task.Delay(500);
        Console.WriteLine("55%");
        await Task.Delay(500);
        Console.WriteLine("56%");
        await Task.Delay(500);
        Console.WriteLine("57%");
        await Task.Delay(500);
        Console.WriteLine("58%");
        await Task.Delay(500);
        Console.WriteLine("59%");
        await Task.Delay(500);
        Console.WriteLine("60%");
        await Task.Delay(500);
        Console.WriteLine("61%");
        await Task.Delay(500);
        Console.WriteLine("62%");
        await Task.Delay(500);
        Console.WriteLine("63%");
        await Task.Delay(500);
        Console.WriteLine("64%");
        await Task.Delay(500);
        Console.WriteLine("65%");
        await Task.Delay(500);
        Console.WriteLine("66%");
        await Task.Delay(500);
        Console.WriteLine("67%");
        await Task.Delay(500);
        Console.WriteLine("68%");
        await Task.Delay(500);
        Console.WriteLine("69%");
        await Task.Delay(500);
        Console.WriteLine("70%");
        await Task.Delay(500);
        Console.WriteLine("71%");
        await Task.Delay(500);
        Console.WriteLine("72%");
        await Task.Delay(500);
        Console.WriteLine("73%");
        await Task.Delay(500);
        Console.WriteLine("74%");
        await Task.Delay(500);
        Console.WriteLine("75%");
        await Task.Delay(500);
        Console.WriteLine("76%");
        await Task.Delay(500);
        Console.WriteLine("77%");
        await Task.Delay(500);
        Console.WriteLine("78%");
        await Task.Delay(500);
        Console.WriteLine("79%");
        await Task.Delay(500);
        Console.WriteLine("80%");
        await Task.Delay(500);
        Console.WriteLine("81%");
        await Task.Delay(500);
        Console.WriteLine("82%");
        await Task.Delay(500);
        Console.WriteLine("83%");
        await Task.Delay(500);
        Console.WriteLine("84%");
        await Task.Delay(500);
        Console.WriteLine("85%");
        await Task.Delay(500);
        Console.WriteLine("86%");
        await Task.Delay(500);
        Console.WriteLine("87%");
        await Task.Delay(500);
        Console.WriteLine("88%");
        await Task.Delay(500);
        Console.WriteLine("89%");
        await Task.Delay(500);
        Console.WriteLine("90%");
        await Task.Delay(500);
        Console.WriteLine("91%");
        await Task.Delay(500);
        Console.WriteLine("92%");
        await Task.Delay(500);
        Console.WriteLine("93%");
        await Task.Delay(500);
        Console.WriteLine("94%");
        await Task.Delay(500);
        Console.WriteLine("95%");
        await Task.Delay(500);
        Console.WriteLine("96%");
        await Task.Delay(500);
        Console.WriteLine("97%");
        await Task.Delay(500);
        Console.WriteLine("98%");
        await Task.Delay(500);
        Console.WriteLine("99%");
        await Task.Delay(500);
        Console.WriteLine("100%"); */

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