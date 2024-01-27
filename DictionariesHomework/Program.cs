Dictionary<int, string> employees = new Dictionary<int, string>();
bool isFinished = false;

do
{
    Console.Write("Id: ");
    string idInput = Console.ReadLine();

    Console.Write("Name: ");
    string nameInput = Console.ReadLine();

    (bool isValidId, bool isValidName) = isEmployeeDataValid(idInput, nameInput);

    if (isValidId && isValidName)
    {
        bool wasAdded = employees.TryAdd(int.Parse(idInput), nameInput);

        Console.WriteLine(wasAdded ? $"Record of ID: {idInput}, Name: {nameInput} added to employee dictionary" :
            $"Could not add a new record to employee dictionary: ID of {idInput} already exists");
    }
    else
    {
        Console.WriteLine($"Invalid entry: Id valid - {isValidId}, Name valid - {isValidName}");
    }

    Console.WriteLine("Proceed filling dictionary? (type FINISH to finish, type anything else to proceed)");
    string finishInput = Console.ReadLine();

    if (finishInput?.ToLower() == "finish")
        isFinished = true;
} while (!isFinished);

Console.WriteLine();
Console.WriteLine("[EMPLOYEES LIST]");

foreach (KeyValuePair<int, string> name in employees)
{
    Console.WriteLine($"ID: {name.Key}, NAME: {name.Value}");
}

isFinished = false;

do
{
    Console.WriteLine("Try get employee name by ID: ");

    bool isIdValid = int.TryParse(Console.ReadLine(), out int id);
    if (isIdValid)
    {
        bool isInDictionary = employees.TryGetValue(id, out string name);

        Console.WriteLine(isInDictionary ? $"Employee {id} name is {name}" :
            $"No id of {id} presented in employees dictionary");
    }
    else
    {
        Console.WriteLine("ID input is not valid");
    }

    Console.WriteLine("Proceed getting employees? (type FINISH to finish, type anything else to proceed)");
    string finishInput = Console.ReadLine();

    if (finishInput?.ToLower() == "finish")
        isFinished = true;
} while (!isFinished);

Console.WriteLine("Finished");
Console.ReadLine();

(bool, bool) isEmployeeDataValid(string id, string name)
{
    bool isIdValid = int.TryParse(id, out _);
    bool isNameValid = !string.IsNullOrWhiteSpace(name);

    return (isIdValid, isNameValid);
}