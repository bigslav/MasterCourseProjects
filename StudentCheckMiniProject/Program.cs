using ConsoleRequestDataLibrary;

string name = string.Empty;
int age = 0;

name = RequestData.RequestString("What's your name: ");

bool isProfessor = false;

switch (name.ToLower()) 
{
    case "bob" or "sue":
        isProfessor = true;
        Console.WriteLine("Hello professor!");
        break;
    default:
        Console.WriteLine($"Hello {name}");
        break;
}

if (!isProfessor) 
{
    age = RequestData.RequestInt("What's your age: ", IntType.PositiveOnly);

    if (age < 21)
        Console.WriteLine("Too young for a course!");
    else
        Console.WriteLine("Go study!");
}