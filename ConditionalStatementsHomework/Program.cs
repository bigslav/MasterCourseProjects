bool isValidInput = false;
string name = String.Empty;

while (!isValidInput) 
{
    Console.WriteLine("What's your name: ");
    name = Console.ReadLine();

    if(!string.IsNullOrEmpty(name))
        isValidInput = true;
}

if (name.ToLower() == "tim")
    Console.WriteLine("Hello professor!");
else
    Console.WriteLine("Hello student!");

switch (name.ToLower())
{
    case "tim":
        Console.WriteLine("Hello professor!");
        break;
    default:
        Console.WriteLine("Hello student!");
        break;
}