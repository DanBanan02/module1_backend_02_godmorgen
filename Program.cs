
Console.Clear();
// Char Extraction / use of char.
// .Length er antallet, begynner fra 0 til 15.
// samme som while loop, men må ha track i stede. (condition)
string MyText = "Hello, Person";

Console.WriteLine(MyText.Length);

Console.WriteLine(MyText[0]);
Console.Write(MyText[1]);
Console.Write(MyText[2]);

Console.WriteLine(MyText[15]);
for (int i = 0; i < MyText.Length; i++)
{
    Console.Write(MyText[i]);
}

foreach (var item in collection)
{
    
}