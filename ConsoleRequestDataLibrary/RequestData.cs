namespace ConsoleRequestDataLibrary
{
    public enum IntType
    {
        PositiveOnly,
        NegativeOnly,
        Any
    }

    public static class RequestData
    {
        public static string RequestString(string message) 
        {
            string output;
            bool isInputValid = false;

            do
            {
                Console.WriteLine(message);

                output = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(output))
                    Console.WriteLine("Invalid input (expected string value - possibly empty or whitespaces)");
                else
                    isInputValid = true;
            }
            while (!isInputValid);

            return output;
        }

        public static int RequestInt(string message, IntType intType)
        {
            int output;
            bool isInputValid = false;

            do
            {
                Console.WriteLine(message);

                isInputValid = int.TryParse(Console.ReadLine(), out output);

                if (isInputValid)
                {
                    switch (intType)
                    {
                        case IntType.PositiveOnly:
                            if (output <= 0)
                            {
                                isInputValid = false;
                                Console.WriteLine("Invalid input (expected positive int)");
                            }
                            break;
                        case IntType.NegativeOnly:
                            if (output >= 0)
                            {
                                isInputValid = false;
                                Console.WriteLine("Invalid input (expected negative int)");
                            }
                            break;
                        case IntType.Any:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input (expected int value)");
                }
            }
            while (!isInputValid);

            return output;
        }
    }
}
