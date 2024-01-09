// "Library" - user can write down text key-value pairs and can output values by writing keys

// Breakdown into steps

// Reserve special characters for "command" and "exit"
// Command => restart command scenario
// Exit => exit app

// Command scenario
// Ask for command
// command == set
// // ask for key => repeat if invalid input
// // ask for value => repeat if invalid input
// command == get
// // ask for key => repeat if invalid input


Console.WriteLine("Write command to restart request\n" +
                  "Write exit to exit program\n");

bool isExitCommand = false;

while (!isExitCommand) 
{
    Console.WriteLine("Write set to make key-value entry\n" +
                      "Write get to get entry value by key\n");


    string? userInput = RequestInput();

    switch (userInput)
    {
        case "exit":
            isExitCommand = true;
            break;
        case "command":
            break;
        case "get":
            // start get
            break;
        case "set":
            // start set
            break;
        default:
            break;
    }
}

string? RequestInput() 
{
    bool isValidInput = false;
    string? userInput = "";

    while (!isValidInput) 
    { 
        Console.Write(">> ");
        
        userInput = Console.ReadLine();

        if (!String.IsNullOrEmpty(userInput))
            isValidInput = true;
    }

    return userInput;
}