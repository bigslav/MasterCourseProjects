bool test = new ();
Console.WriteLine($"default bool value is: {test}");
Console.WriteLine(!test);

// bool not a ref type
bool a = true;
bool b = a;
a = false;

Console.WriteLine ($"{a}, {b}");

// null represents an abscence of a value or reference

bool? nullableBool = null;

// usages of Nullable interface
Console.WriteLine($@"has value: {nullableBool.HasValue},
value of nullable: {(nullableBool.HasValue ? nullableBool.Value : "null")},
get value or default: {nullableBool.GetValueOrDefault()},
is equal null: {nullableBool.Equals(null)}");

// string is ref type, can be assigned null
// compiler gives warning, because although string can be assigned null
// we can treat it as non-nullable type and get error at some point
string testString = null;

// safer to use nullable string
string? testString2 = null;
