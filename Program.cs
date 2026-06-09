// clear the console
Console.Clear();

// Product Array
string[] products = { "Soup", "Cat Food", "Dog Food"};

// Users Shooping cart List
List<string> cart = new List<string>();

// Shows avaiable products
static void ShowProducts(string[] availableProducts)
{

    Console.WriteLine(availableProducts[0]);

    foreach (string availableProductsproduct in availableProducts)
    {
        Console.WriteLine(availableProductsproduct);
    }

}

ShowProducts(products);

// Show cart content
static void ShowCartContents(List<string> userShoppingCart)
{
    Console.WriteLine("Item in cart: ");
    foreach (string item in userShoppingCart)
    {
        Console.WriteLine(item);
    }
}
// cart.Add("Soup");
// ShowCartContents(cart);

// Add an item to cart
static void AddItemToCart(string ItemName)
{
    // Logic to add item to cart goes here:
    

}
static void RemoveItemToCart(string ItemName)
{
    // Logic to Remove item from cart goes here:
    
}

// UI

while (true)
{
    Console.Clear();

    Console.WriteLine("Shopping cart app ");
Console.WriteLine();
Console.WriteLine("1. View avaiable product: ");
Console.WriteLine("2. View my shopping art");
Console.WriteLine("3. Add a product to cart");
Console.WriteLine("4. Remove a product from cart");
Console.WriteLine("5. Exit");

Console.WriteLine("Choose an option: ");

string choice = Console.ReadLine();

Console.WriteLine();

// Adding Logic
if (choice == "1")
    {
        // Might miss Parameter = Previous calling.

        ShowProducts(products);
        Console.ReadLine(); // Temporary break
    }
    else if (choice == "2") // View my cart
    {
        ShowCartContents(cart);
    }
    else if (choice == "3") // Add product to cart
    {
        cart.Add("");
    }
    else if (choice == "4") // Remove product from cart
    {
        
    }
    else if (choice == "5") // Exit function
    {
        
    }

}