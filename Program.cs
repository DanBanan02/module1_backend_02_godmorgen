// clear the console
Console.Clear();

// Check password strenght
string passowrd = "abcd2";

// Does password contain a number?
bool hasNumber = false;

// Ideas: Check Lenght 7
int minLenght = 8;

foreach (char character in passowrd)
{
    if (char.IsDigit(character))
    {
        hasNumber = true;
    }
    
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

if ( passowrd.Length >= minLenght)
{
    Console.WriteLine("Password is long enough");
}