try
{
    BadCall();
    // is ignored, because of an exception in a first call
    BadCallWithInfo();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

Console.ReadLine();

try
{
    BadCallWithInfo();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

void BadCall()
{
    int[] array = { 1, 2, 3, 4 };

    for (int i = 0; i < 5; i++)
    {
        try
        {
            Console.WriteLine(array[i]);
        }
        catch (Exception)
        {
            Console.WriteLine("BadCall");
            throw;
        }
    }
}

void BadCallWithInfo()
{
    int[] array = { 1, 2, 3, 4 };

    for (int i = 0; i < 5; i++)
    {
        try
        {
            Console.WriteLine(array[i]);
        }
        catch (Exception e)
        {
            Console.WriteLine("BadCallWithInfo");
            throw new Exception("Outside of bounds of array", e);
        }
    }
}