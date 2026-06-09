cd..                                                                                                
dir                                                                                                 
mkdir module1_backend_02_godmorgen
cd .\module1_backend_02_godmorgen\
dotnet new console
dotnet new gitignore
code .
--> source controle --> initialize repository -> "init" --> publish --> public / private


____________________________________________

ReadMe Del 2
============================================

# Learning Objectives for this repo
- what is a loop, and why they're useful
- type of loops in C#
- how to start them in C#
- how to start them, stop them and also break out early.
- Infitite loops
- Leveraging loops with TUI apps (Terminal User Interface)
- Using loops with collections (List, Ararys, etc.)

______________________________
Break = stop
==============================
Breaks (are used to stop loops early useful to avoid infinitie loops if we want diffrent condition to terminate it)

Console.WriteLine();
break;
Console.WriteLine();
if (true)

    if ()
    {
        break;
    }


______________________________
Return = 
==============================
Return; a return statment 

______________________________
While = 
==============================


______________________________
int = 
==============================
for loop example
for loop needs 3 things in its declaration line ( for ())

1. An interator (a counter variable)

2. a condition

3. A increment or decrement Rule

Sample: 
for (int i = 0; i < 10; i++)
{
    // is only available here.
}

multiple loops in "int"

______________________________
for loop = 
==============================

______________________________
Scope 
==============================

scope in i scope kan ikke brukes via int...




______________________________
Infinity loop
==============================

// clear the console
Console.Clear();

while(true)
{
    Console.WriteLine("Hello");
    string input = Console.ReadLine();

    Console.WriteLine("Name:" + input);
}



______________________________
Char
==============================

// Intro to Collections

// Only Single Letter / Character / No-Math
char character = 'a';

Console.WriteLine("Character1");

______________________________
Foreach
==============================

string = collection
string = list of characters

______________________________
Cheat Sheet:
==============================

Return Type	Gives Back:

void	=   Nothing
int	    =   Number
string	=   Text
bool	=   true or false
char    =	Single character

Think of return as:
"Take this value and send it back to whoever called me."

______________________________
Diff Pasword.
==============================

// clear the console
Console.Clear();

// Check password strenght
string passowrd = "abcd2";

// Does password contain a number?
bool hasNumber = false;
foreach (char character in passowrd)
{
    hasNumber = char.IsDigit(character);
    // Console.WriteLine(hasNumber);
    // Console.WriteLine(character.IsDigit);

}

// check if password strenght passes our critteria
if (hasNumber)
{
    // Happens if password does contain number.
    Console.WriteLine("Password contains a number, so we're all good!");
}
else
{
    // happens if pasword does not contain ( Number )
    Console.WriteLine("Password needs to contain a number! DO BETTER!");
}


______________________________
Item Listing....
==============================

// More diff ways of listing items.

/*  string product1 = "Coffe";
    string product2 = "Tea";
    string Product3 = "Bun"; 
*/

______________________________
Standard foreach
==============================


    
    foreach (var Number in Numbers)
    {
        
    }


_______________________________
Referat:
===============================

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