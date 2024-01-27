string userInput = string.Empty;
bool isInputValid = false;
List<string> names = new();

do
{
    Console.WriteLine("Write a comma-separated list of names:");
    userInput = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(userInput))
    {
        isInputValid = true;

        names = userInput.Split(',').ToList();

        for (int i = 0; i < names.Count; i++)
        {
            names[i] = names[i].Trim();
        }
    }
} while (!isInputValid);

for (int i = 0; i < names.Count; i++) 
{
    Console.WriteLine($"Hello {names[i]}");
}

Console.ReadLine();