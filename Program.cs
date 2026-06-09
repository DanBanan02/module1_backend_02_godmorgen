// clear the console
Console.Clear();

// Array = Type collection

string[] products = {"Coffe", "Tea", "Bun"};

Console.WriteLine("Our Products");
// Products er connected with {Items inside brackets.}
Console.WriteLine(products);

// int, bool, char, string, Objects, arrays, ...

// Arrays, are fixed lenght and types.

foreach (var product in products)
{
    Console.WriteLine(product);
}

Console.WriteLine();
// list: are basically a collection that can grow in size.

// a shopping ( Basket/Cart ) as a list ( Example: )

List<string> cart = new List<string>();

cart.Add("Coffe");
cart.Add("Soup");

Console.WriteLine("Your Shopping cart" + cart.Count);

foreach (string item in cart)
{
    Console.WriteLine(item);
}

// Removes a spesific item in cart.
cart.Remove("Soup");

