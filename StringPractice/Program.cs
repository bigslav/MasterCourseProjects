// Common way to init empty string
string testText = string.Empty;
Console.WriteLine(testText);

testText = "test";

// When testText is modified a new string is created
// testTextHolder points to an old string object, that's why it's text is not modified
string testTextHolder = testText;
testText += testTextHolder;

// Using interpolation with $ sign allows to inject variable into text
// Using verbatim with @ allows to ignore \ special symbol,
// allow to use double quotes for quotes in text 
// and to treat new line characters as a part of a string
Console.WriteLine($@"\\\ ""testText"": {testText}
\\\ ""testTextHolder"": {testTextHolder}");

// string is a collection of chars
foreach (char item in testText)
{
    Console.WriteLine($"\v\t{item}");
}

// reverse string with linq (possibly not the best implementation - just works)
Console.WriteLine(new string(testText.Reverse().ToArray()));