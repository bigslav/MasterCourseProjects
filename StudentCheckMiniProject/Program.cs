using ConsoleHelpers;

string name = string.Empty;
int age = 0;


name = "What's your name: ".RequestString();
"What's your department? (Programming or Math)".RequestString(new List<string>{"programming", "math"});
"What's your favorite case-sensitive string? (CHaKa or bObA)".RequestString(new List<string>{"CHaKa", "bObA"}, true);
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
    age = "What's your age: ".RequestInt(0, 120);

    if (age < 21)
        Console.WriteLine("Too young for a course!");
    else
        Console.WriteLine("Go study!");
}