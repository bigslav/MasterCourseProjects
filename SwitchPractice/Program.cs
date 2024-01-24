// conditionals inside switch cases

bool isValidInput = false;
int number = 0;

while (!isValidInput)
{
    Console.Write("Pick a number: ");
    isValidInput = int.TryParse(Console.ReadLine(), out number);
}

switch (number)
{
    case > 0:
        Console.WriteLine("It's positive");
        break;
    case < 0:
        Console.WriteLine("It's negative");
        break;
    default:
        Console.WriteLine("It's zero");
        break;
}

switch (number) 
{
    case > 0 and <= 100:
        Console.WriteLine("It's between 1 and 100");
        break;
    case > 100 or < -100:
        Console.WriteLine("It's absolute value is more than 100");
        break;
}
