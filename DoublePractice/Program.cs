double test = new();

Console.WriteLine($"double default value is: {test}");
Console.WriteLine($@"double max value: {double.MaxValue}
double min value: {double.MinValue}");

double zeroDouble = 0.0;
double oneDouble = 1.0;

// negative infinity, positive infinity and NaN
Console.WriteLine($@"-1 / 0 = {-oneDouble / zeroDouble}
1 / 0 = {oneDouble / zeroDouble}
0 / 0 = NaN == {zeroDouble / zeroDouble}
");

// NaNs are not equal
Console.WriteLine(double.NaN == double.NaN);

// division operator returns int
double lostData = 1 / 2;
Console.WriteLine(lostData);

// fix
lostData = 1.0 / 2.0;
Console.WriteLine(lostData);

Console.WriteLine($"minimal positive number (epsilon): {double.Epsilon}");

// Heavily used in math calculations
Console.WriteLine(Math.Exp(5.0));
Console.WriteLine(Math.PI + $"- PI is {Math.PI.GetType()}");