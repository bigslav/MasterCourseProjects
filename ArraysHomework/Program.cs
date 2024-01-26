string namesData = "Bob+Bib+Bab";

string[] names = namesData.Split('+');

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Name {i} is {names[i]}");
}

int chosenIndex;
bool isValidInput;

do
{
    Console.Write("Type name index: ");
    isValidInput = int.TryParse(Console.ReadLine(), out chosenIndex);

    if (chosenIndex < 0
        || chosenIndex > names.Length - 1)
    {
        Console.WriteLine("Wrong index");
        isValidInput = false;
    }
} while (!isValidInput);

Console.WriteLine($"You chose {names[chosenIndex]}");