// Console View alterations

bool isThemeChosen = false;
string? chosenThemeName = null;

while (!isThemeChosen) 
{
    Console.WriteLine(@"Select a theme: type ""light"", ""dark"" or ""matrix""");

    chosenThemeName = Console.ReadLine();
    isThemeChosen = TrySetTheme(chosenThemeName);
}

//Changing out stream for logging, logging and closing output

StreamWriter logWriter = new StreamWriter(@".\Log.txt");
logWriter.AutoFlush = true;
Console.SetOut(logWriter);
Console.Out.WriteLine($"{DateTime.UtcNow}: {chosenThemeName} theme chosen");
Console.Out.Close();

//Changing out stream back to console standard

StreamWriter standartOutput = new StreamWriter(Console.OpenStandardOutput());
standartOutput.AutoFlush = true;
Console.SetOut(standartOutput);
Console.WriteLine($"{chosenThemeName} theme is successfully chosen");

//Reading logs file contents
StreamReader logReader = new StreamReader(@".\Log.txt");

Console.ReadLine();

bool TrySetTheme(string? themeName) 
{
    switch (themeName)
    {
        case "light":
            SetTheme(ConsoleColor.White, ConsoleColor.Black);
            return true;
        case "dark":
            SetTheme(ConsoleColor.Black, ConsoleColor.White);
            return true;
        case "matrix":
            SetTheme(ConsoleColor.Black, ConsoleColor.Green);
            return true;
        default:
            Console.WriteLine("Invalid theme name, try again\n");
            return false;
    }
}

void SetTheme(ConsoleColor backgroundColor, ConsoleColor foregroundColor) 
{
    Console.BackgroundColor = backgroundColor;
    Console.ForegroundColor = foregroundColor;
    Console.Clear();
}