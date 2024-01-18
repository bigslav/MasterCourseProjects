using System.Globalization;

DateTime localNow = DateTime.Now;

// can format output in different ways
// in example "day.month.year hours:minutes:seconds" -> "year day/monthShort offsetFromUtc"
Console.WriteLine(localNow);
Console.WriteLine($"Formatted: {localNow.ToString("yyyy dd/M zz")}");
// simplified interpolation
Console.WriteLine($"Formatted: {localNow:yyyy dd/M zz}");

// culture-independent representation of time
Console.WriteLine(localNow.ToString(CultureInfo.InvariantCulture));
// japanese representation of time
Console.WriteLine(localNow.ToString(new CultureInfo("ja-JP")));

// get UTC time
DateTime utcNow = DateTime.UtcNow;
Console.WriteLine($"Time in UTC: {utcNow:yyyy dd/M zz}");

// various usages
Console.WriteLine($"days in february of 1998: {DateTime.DaysInMonth(1998, 11)}");
Console.WriteLine($"day of week on 11.11.1998: {new DateTime(1998, 11, 11).DayOfWeek}");
Console.WriteLine($"was 1998 a leap year: {DateTime.IsLeapYear(1998)}");