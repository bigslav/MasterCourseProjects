string introTextData = "Hello!,Type in students' names,When there are no names left type in FINISH";
// separated data to list
List<string> dataToList = introTextData.Split(",").ToList();
foreach (string element in dataToList)
{
    Console.WriteLine(element);
}

List<string> studentNames = new List<string>();
bool isFinished = false;

do
{
    Console.Write("Name: ");

    string input = Console.ReadLine();
    bool isValidInput = !string.IsNullOrWhiteSpace(input);

    if (isValidInput)
    {
        switch (input.ToLower())
        {
            case "finish":
                isFinished = true;
                break;
            default:
                studentNames.Add(input);
                break;
        }
    }
    else
    {
        Console.Write("Invalid name, try again\n");
    }
} while (!isFinished);

Console.WriteLine();
Console.WriteLine("[STUDENTS LIST]");

foreach (string name in studentNames)
{
    Console.WriteLine(name);
}

Console.WriteLine($"TOTAL: {studentNames.Count} student");
Console.ReadLine();