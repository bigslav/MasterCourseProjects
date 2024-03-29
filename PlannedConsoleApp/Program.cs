﻿using System.Drawing;

// Program that asks for text input and outputs text's characters one by one in random color

// Breakdown into steps

// Greet user, instruct how program works
Console.WriteLine("Hello! Write down something to get fancy text. Type QUIT to exit application.");


Random random = new Random();
bool isFinished = false;

// Ask to write down text in loop
while (!isFinished) 
{
    Console.Write(">> ");
    string? input = Console.ReadLine();

    // Exit app if QUIT typed
    if (input == "QUIT") 
    {
        isFinished = true;
        continue;
    }

    // Validate text => if not valid ask again
    if (String.IsNullOrEmpty(input)) 
    {
        Console.WriteLine("Empty input, try again.");
        continue;
    }

    ConsoleColor defaultTextColor = Console.ForegroundColor;

    Array consoleForegroundColors = Enum.GetValues<ConsoleColor>();

    // Write characters one by one
    foreach (var character in input) 
    {
        // Set random text color
        ConsoleColor newRandomTextColor = GetRandomTextColor(consoleForegroundColors);
        Console.ForegroundColor = newRandomTextColor;
        Console.WriteLine(character);
    }

    // Set text color back to normal
    Console.ForegroundColor = defaultTextColor;
}

ConsoleColor GetRandomTextColor(Array consoleForegroundColors) 
{
    ConsoleColor newRandomTextColor;

    do
    {
        int randomIndex = random.Next(consoleForegroundColors.Length);
        newRandomTextColor = (ConsoleColor)consoleForegroundColors.GetValue(randomIndex);
    } while (newRandomTextColor == Console.BackgroundColor);

    return newRandomTextColor;
}