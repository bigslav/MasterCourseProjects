string userInput = string.Empty;
bool isExiting = false;

do
{
    Console.WriteLine("Name: ");
    userInput = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(userInput))
        continue;

    switch (userInput.ToLower())
    {
        case "tim":
            Console.WriteLine("Hi Tim!");
            break;
        case "exit":
            Console.WriteLine("Exiting...");
            isExiting = true;
            break;
        default:
            Console.WriteLine($"Hi student {userInput}!");
            break;
    }
} while (!isExiting);

Console.ReadLine();