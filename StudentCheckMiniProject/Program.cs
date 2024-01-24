string name = string.Empty;
int age = 0;

bool isInputValid = false;
while (!isInputValid)
{
    Console.Write("What's your name: ");
    name = Console.ReadLine();

    if (!string.IsNullOrEmpty(name))
        isInputValid = true;
}

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
    isInputValid = false;
    while (!isInputValid)
    {
        Console.Write("What's your age: ");
        isInputValid = int.TryParse(Console.ReadLine(), out age);

        if (age < 0)
            isInputValid = false;
    }

    if (age < 21)
        Console.WriteLine("Too young for a course!");
    else
        Console.WriteLine("Go study!");
}