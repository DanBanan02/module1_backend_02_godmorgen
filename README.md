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