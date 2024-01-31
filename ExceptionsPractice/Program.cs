int number = 0;

try
{
    int.TryParse(Console.ReadLine(), out number);
    WrongArgumentCall(number);
}
// catches if == 0
catch (ArgumentException ex) when (number == 0)
{
    Console.WriteLine(ex);
}
// catches if < 0
catch (ArgumentException ex) when (number < 0)
{
    Console.WriteLine(ex);
}
// catches if > 0
catch (Exception ex)
{
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("Try finished");
}

Console.ReadLine();

void WrongArgumentCall(int number)
{
    if (number < 0)
    {
        throw new ArgumentException("Number is less than 0");
    }
    else if (number == 0)
    {
        throw new ArgumentException("Number is  0");
    }
    else
    {
        throw new ArgumentException("Something wrong with the number");
    }
}