// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting string content

float f1 = 123.4f;
int i1 = 2000;

// TODO: Spacing and Alignment: Indexes
Console.WriteLine("{0, -15} {1,10}", "FLoat Val", "Int Val");
Console.WriteLine("{0, -15} {1,10}", f1, i1);

// TODO: Spacing and Alignment: Interpolation
Console.WriteLine($"{"FLoat Val", -15} {"Int Val",10}");
Console.WriteLine($"{f1, -15} {i1,10}");
