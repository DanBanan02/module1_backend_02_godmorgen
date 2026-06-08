// this makes the class flow, into it's focus...
class Program
{
    // This one has string connector
       static void NeedThisToWork(string Here)
    {   // Static Void is closed to this one.
        Console.WriteLine("Place string here:" + Here);
    }

    static void Main() // Main Meaning ( Core function )
    {   // This Continues anyway ( Unless string is added.)
        NeedThisToWork("This Continues down here...");
    }
}