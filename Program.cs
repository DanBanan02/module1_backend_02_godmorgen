// Current Time
// Check Current time and gives the information back to the code.
// Prints the set Message to current Time: ( Text given )
DateTime now = DateTime.Now;

// If Time is between 6-12 = God Morgen
if (now.TimeOfDay >= new TimeSpan(6, 0, 0) && now.TimeOfDay <= new TimeSpan(12, 0, 0))


{
    // Text: God Morgen
    Console.WriteLine("God morgen");
}

// If Time is between 13-18 = God ettermidag
else if (now.TimeOfDay >= new TimeSpan(13, 0, 0) && now.TimeOfDay <= new TimeSpan(18, 0, 0))

{
    // Text: God EtterMidag
    Console.WriteLine("God ettermidag");
}

// IF Time is between 19-00 = God Kveld
else if (now.TimeOfDay >= new TimeSpan(19, 0, 0) && now.TimeOfDay <= new TimeSpan(0, 0, 0))

{
    // Text: God Kveld
    Console.WriteLine("God Kveld");
}

// If Time is between 01-05 = God Natt
else if (now.TimeOfDay >= new TimeSpan(1, 0, 0) && now.TimeOfDay <= new TimeSpan(5, 0, 0))

{
    // Text: God Natt
    Console.WriteLine("God Natt");
}

// If non of the above happens this will ping insted.
Console.WriteLine(now.ToString("HH:mm"));