

Console.Clear();

// useful string properties and metohds
// (property): length
// (method): ToUpper() // ToLower() (to convert lower or upper case)
// (method): Contains (Some char) // check if a string contains a specific character.

string myText = "hello, World.";

for (int i = 0; i < myText.Length; i++)
{
    /* Console.Write(MyText[i]); */
}

foreach (var Noob in myText)
{
    Console.Write(Noob);
}

myText.Contains();