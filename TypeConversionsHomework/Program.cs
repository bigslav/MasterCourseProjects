const int ageGap = 25;

bool isInputValid = false;
int age = 0;

while (!isInputValid)
{
    Console.WriteLine("How old are you?");
    isInputValid = int.TryParse(Console.ReadLine(), out age);

    if (!isInputValid)
        Console.WriteLine("Invalid input, try again");
    
    Console.WriteLine();
}

int ageMinusGap = age - ageGap;
Console.WriteLine(ageMinusGap >= 0 ? $"You were {ageMinusGap} years old {ageGap} years ago" 
                  : $"You were not born yet {ageGap} years ago");

int agePlusGap = age + ageGap;
Console.WriteLine($"In {ageGap} years you would be {agePlusGap} years");

Console.ReadLine();