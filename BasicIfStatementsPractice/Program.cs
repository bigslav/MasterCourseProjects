
bool isInputValid = false;
int number = 0;

while (!isInputValid)
{
    Console.Write("Pick a number: ");
    isInputValid = int.TryParse(Console.ReadLine(), out number);

    if(!isInputValid)
        Console.WriteLine("Not a number\n");
}

if (number > 0)
    Console.WriteLine("Number is positive");
else if (number < 0)
    Console.WriteLine("Number is negative");
else
    Console.WriteLine("Number is zero");

switch (number)
{
    case 0:
        Console.WriteLine("ZERO");
        break;
    case 100:
        Console.WriteLine("HUNDRED");
        break;
    default:
        Console.WriteLine("Not a zero or a hundred");
        break;
}
