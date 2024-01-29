// data variable of tuple type, get elements with data.ItemN
(int, int) data = GetSumAndMultiplication(2, 3);
Console.WriteLine($"sum: {data.Item1}, mult: {data.Item2}");

// items can be renamed
(int sum, int mult) dataNamedElements = GetSumAndMultiplication(2, 3);
Console.WriteLine($"sum: {dataNamedElements.sum}, mult: {dataNamedElements.mult}");

// can store returned values in separate variables initialized inside tuple
(int sum, int mult) = GetSumAndMultiplication(2, 3);
Console.WriteLine($"sum: {sum}, mult: {mult}");

//discard unused returned value
(int sumOnly, _) = GetSumAndMultiplication(2, 3);
Console.WriteLine($"sum only: {sumOnly}");

(int, int) GetSumAndMultiplication(int x, int y)
{
    return (x + y, x * y);
}