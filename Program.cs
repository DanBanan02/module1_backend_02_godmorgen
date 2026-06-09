// clear the console
Console.Clear();

// Methods (also called as "fuctions")

// Show Greeting in Console
// Declarasion of a methods

// Add a string to the static void

static void Greet(string customGreeting)
{
    Console.WriteLine("Hello!");
}

// Navn etter fulgt av ();
/* Greet();
 */

// Function calld by X amount of loops
 for (int i = 0; i < 5; i++)
 {
    // if string add "" or add text inside "Text"
    Greet("Text" + i + "nth time!");
 }

// Consume the method
Console.Write("");