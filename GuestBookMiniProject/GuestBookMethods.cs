namespace GuestBookMiniProject;

public static class GuestBookMethods
{
    public static string AskForGuestName()
    {
        string output;
        bool isInputValid = false;

        do
        {
            Console.WriteLine("Guest name: ");

            output = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(output))
                Console.WriteLine("Not a valid name, try again");
            else
                isInputValid = true;
        }
        while (!isInputValid);

        return output;
    }

    public static int AskForGuestCompanionsCount(string guestName)
    {
        int output;
        bool isInputValid = false;

        do
        {
            Console.WriteLine($"How many guests are with {guestName}?");

            isInputValid = int.TryParse(Console.ReadLine(), out output);

            if (output < 0)
                isInputValid = false;

            if (!isInputValid)
                Console.WriteLine("Not a valid companions count, try again");
        }
        while (!isInputValid);

        return output;
    }

    public static bool AskIfGuestBookFilled()
    {
        bool output;

        Console.WriteLine("Are any more guests coming? (type yes to continue or anything else to finish)");
        string input = Console.ReadLine();

        output = input?.ToLower() != "yes";

        return output;
    }

    public static void PrintGuestList(List<Guest> guests)
    {
        Console.WriteLine("[GUEST LIST]");
        foreach (Guest guest in guests)
        {
            Console.WriteLine($"{guest.name} with {guest.companionsCount} companions");
        }

        Console.WriteLine($"Total number of guests is: {GetTotalGuestsCount(guests)}");
    }

    static int GetTotalGuestsCount(List<Guest> guests)
    {
        int output = 0;

        foreach (Guest guest in guests)
        {
            output += guest.companionsCount + 1;
        }

        return output;
    }
}
