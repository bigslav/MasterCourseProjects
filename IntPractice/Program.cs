int testInt = 12;
Console.WriteLine(testInt);

// signed int64 - first bit is reserved for sign value + or -
Console.WriteLine(Int64.MaxValue);
Console.WriteLine(UInt64.MaxValue);

int a = 1;
int b = 2;

// when dividing ints the tail is dropped
Console.WriteLine(a / b);

// overflow relative to min and max values
int minValue = int.MinValue;
int maxValue = int.MaxValue;

Console.WriteLine(minValue - 1);
Console.WriteLine(maxValue + 1);

// output powers of 2 until value overflowed
int value = 2;
int power = 0;
bool needStop = false;

while (!needStop)
{
    int poweredValue = (int) MathF.Pow(value, power);

    if (poweredValue < 0)
    {
        needStop = true;
    }
    else
    {
        Console.WriteLine(poweredValue);
        power++;
    }
}