namespace MethodsHomework;

public static class ConsoleMethods
{
    public static void WelcomeUser()
    {
        Console.WriteLine("Hello user!");
    }

    public static string AskForName()
    {
        string output;

        Console.WriteLine("What's your name: ");

        bool isNameValid = false;

        do
        {
            output = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(output))
                isNameValid = true;
            else
                Console.WriteLine("Wrong name, try again");
        }
        while (!isNameValid);

        return output;
    }

    public static void GreetUserByName(string userName)
    {
        Console.WriteLine($"Hello, {userName}!");
    }
}
