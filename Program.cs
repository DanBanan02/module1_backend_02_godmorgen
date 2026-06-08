// clear the console
using System.Numerics;

Console.Clear();

// sum app:

int total =0;

while(true)
{
    Console.Write("Enter Number:");
    
    String InputNumber = Console.ReadLine();

    int Number = int.Parse(InputNumber);
    total += Number;
    
    Console.WriteLine("Total:" + total);
    }

