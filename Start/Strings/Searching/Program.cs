// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for searching string content

string teststr = "The quick brown Fox jumps over the lazy Dog";

// TODO: Contains determines whether a string contains certain content
Console.WriteLine($"{teststr.Contains("fox")}");
Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}");

// TODO: StartsWith and EndsWith determine if a string starts 
// or ends with a given test string
Console.WriteLine($"{teststr.StartsWith("the")}");
Console.WriteLine($"{teststr.StartsWith("the", StringComparison.CurrentCultureIgnoreCase)}");


// TODO: IndexOf, LastIndexOf finds the index of a substring
Console.WriteLine($"{teststr.LastIndexOf("Fox")}");
Console.WriteLine($"{teststr.LastIndexOf("evbfe")}");

// TODO: Determining empty, null, or whitespace
string str1 = null;
string str2 = "   ";
string str3 = String.Empty;

Console.WriteLine($"{String.IsNullOrEmpty(str1)}");
Console.WriteLine($"{String.IsNullOrEmpty(str2)}");
