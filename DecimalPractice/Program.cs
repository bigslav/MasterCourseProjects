decimal test = new decimal();

// default value is 0M
Console.WriteLine(test);

// test = 10.1 gives compiler error, implicit conversion of double to decimal can lead to lose of data
// works both ways and with all floating point types (only exception: float -> double)

float a = 1.0f;
double b = a;

Console.WriteLine($@"minValue: {decimal.MinValue}
maxValue: {decimal.MaxValue}");

// decimal has more precision and a smaller range than other floating point types
// used in financial calculations for example
