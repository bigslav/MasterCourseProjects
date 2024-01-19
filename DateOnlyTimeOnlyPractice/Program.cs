// create date using constructor
DateOnly testDate = new DateOnly(1998, 11, 1);
Console.WriteLine(testDate);

// create date using DateOnly.Parse
DateOnly testDate2 = DateOnly.Parse("1.11.1998");
Console.WriteLine(testDate2);

Console.WriteLine($@"01.11.1998
day of week: {testDate.DayOfWeek}
day of year: {testDate.DayOfYear}
day number since 01.01.0001: {testDate.DayNumber}");

// TimeOnly 12PM using constructor
TimeOnly testTime = new TimeOnly(12, 0);
Console.WriteLine(testTime);

// TimeOnly 12PM using TimeOnly.Parse
TimeOnly testTime2 = TimeOnly.Parse("12 PM");
Console.WriteLine(testTime2);

Console.WriteLine($@"12PM
in ticks: {testTime.Ticks}
is between 11 AM and 1 PM: {testTime.IsBetween(TimeOnly.Parse("11 AM"), TimeOnly.Parse("1 PM"))}");

// DateTime still has time part even if we don't set it specificaly 
DateTime testDateTime = DateTime.Parse("11.11.1998");
Console.WriteLine(testDateTime);

// Get DateTime from DateOnly and TimeOnly
DateTime combinedDateAndTimeFromDateOnly = testDate.ToDateTime(testTime);
Console.WriteLine(combinedDateAndTimeFromDateOnly);