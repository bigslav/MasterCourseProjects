using System.ComponentModel;

bool isValidInput = false;
bool isAdult = false;

while (!isValidInput) 
{
    // will throw an exception if input is not bool (true or false, case insensitive)
    // bool isAdult = bool.Parse(Console.ReadLine());

    if (!isValidInput)
        Console.Write("Are you male (true or false): ");

    isValidInput = bool.TryParse(Console.ReadLine(), out isAdult);
}

Console.WriteLine(isAdult ? "You are male" : "You are not male");