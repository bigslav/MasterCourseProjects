namespace ConsoleHelpers
{
    public static class ConsoleHelpers
    {
        public static string RequestString(this string message)
        {
            return message.RequestString(allowedResponses: new List<string>(), false);
        }

        public static string RequestString(this string message, List<string> allowedResponses)
        {
            return message.RequestString(allowedResponses, false);
        }

        public static string RequestString(this string message, List<string> allowedResponses, bool isCaseSensitive)
        {
            string output;
            bool isInputValid = true;

            do
            {
                Console.WriteLine(message);
                output = Console.ReadLine();

                if (allowedResponses.Count != 0)
                {
                    foreach (string response in allowedResponses)
                    {
                        if (isCaseSensitive && output == response)
                        {
                            isInputValid = true;
                            break;
                        }
                        if (!isCaseSensitive && string.Equals(output, response, StringComparison.CurrentCultureIgnoreCase))
                        {
                            isInputValid = true;
                            break;
                        }

                        isInputValid = false;
                    }

                    if (!isInputValid)
                    {
                        Console.WriteLine("Invalid input (expected string value from listed below)");
                        foreach (string response in allowedResponses)
                        {
                            Console.WriteLine(response);
                        }
                    }
                }

                if (isInputValid && string.IsNullOrWhiteSpace(output))
                {
                    Console.WriteLine("Invalid input: empty or whitespaces");
                    isInputValid = false;
                }
            } while (!isInputValid);

            return output;
        }

        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }

        public static int RequestInt(this string message, int minValue, int maxValue)
        {
            return message.RequestInt(true, minValue, maxValue);
        }

        private static int RequestInt(this string message, bool isInRange, int minValue = 0, int maxValue = 0)
        {
            int output;
            bool isInputValid = true;

            do
            {
                isInputValid = int.TryParse(Console.ReadLine(), out output);

                if (!isInRange)
                    continue;

                if (output >= minValue && output <= maxValue)
                    continue;

                isInputValid = false;
            } while (!isInputValid);

            return output;
        }
    }
}