namespace ConsoleRequestDataLibrary
{
    public enum IntType
    {
        Positive,
        Negative,
        PositiveWithZero,
        NegativeWithZero,
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

        public static string RequestString(string message, List<string> allowedResponses, bool isCaseSensitive = false)
        {
            string output;
            bool isInputValid = false;

            do
            {
                output = RequestString(message);

                foreach (string response in allowedResponses)
                {
                    if (isCaseSensitive)
                    {
                        isInputValid = output == response;
                    }
                    else
                    {
                        isInputValid = string.Equals(output, response, StringComparison.CurrentCultureIgnoreCase);
                    }

                    if (isInputValid)
                        break;
                }

                if (!isInputValid)
                {
                    Console.WriteLine("Invalid input (expected string value from listed below)");
                    foreach (string response in allowedResponses)
                    {
                        Console.WriteLine(response);
                    }
                }
            } while (!isInputValid);

            return output;
        }

        public static int RequestInt(string message, IntType intType)
        {
            int output;
            bool isInputValid = false;

            do
            {
                output = RequestInt(message);

                switch (intType)
                {
                    case IntType.Positive:
                        if (output <= 0)
                        {
                            isInputValid = false;
                            Console.WriteLine("Invalid input (expected positive int)");
                        }
                        break;
                    case IntType.Negative:
                        if (output >= 0)
                        {
                            isInputValid = false;
                            Console.WriteLine("Invalid input (expected negative int)");
                        }
                        break;
                    case IntType.PositiveWithZero:
                        if (output < 0)
                        {
                            isInputValid = false;
                            Console.WriteLine("Invalid input (expected positive int or zero)");
                        }
                        break;
                    case IntType.NegativeWithZero:
                        if (output > 0)
                        {
                            isInputValid = false;
                            Console.WriteLine("Invalid input (expected negative int or zero)");
                        }
                        break;
                    case IntType.Any:
                        break;
                }
            }
            while (!isInputValid);

            return output;
        }

        public static int RequestInt(string message, int minValue, int maxValue)
        {
            int output;
            bool isInputValid = false;

            do
            {
                output = RequestInt(message);

                if (output < minValue || output > maxValue)
                {
                    Console.WriteLine($"Invalid input (not in required range [{minValue}, {maxValue}])");
                }
                else
                {
                    isInputValid = true;
                }
            } while (!isInputValid);

            return output;
        }

        public static int RequestInt(string message)
        {
            int output;
            bool isInputValid = false;

            do
            {
                Console.WriteLine(message);

                isInputValid = int.TryParse(Console.ReadLine(), out output);

                if (!isInputValid)
                    Console.WriteLine("Invalid input (expected int value)");
            } while (!isInputValid);

            return output;
        }
    }
}
