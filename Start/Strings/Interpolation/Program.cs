// LinkedIn Learning Course .NET Programming with C# by Joe Marini

// String Interpolation is a feature that enables the easy insertion of data
// and expression values into a string variable

int a = 100;
float b = 250.0f;
string c = "CSharp";

s s1;
s1.a = 5;
s1.b = false;

MyClass cl = new MyClass{a = 5, b = false};

// String output the old way - using placeholders
Console.WriteLine("The values are {0}, {1} and {2}", a, b, c);

// TODO: Using string interpolation, the code is much easier to read
Console.WriteLine($"The values are {a}, {b} and {c}");


// TODO: Interpolated strings can contain expressions as well
Console.WriteLine($"{c} in upper-case is {c.ToUpper()}");

// TODO: Complex objects can be embedded in strings this way as well
DateTime now = DateTime.Now;
Console.WriteLine($"Today is {now}");



Console.WriteLine($"Arghh, {s1} and no, {cl}");


















































// Exercise file for LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for .NET Data Types




// TODO: Create an instance of a struct (which is a value type)


// Perform an operation on a struct
void StructOp(s theStruct) {
    // Modify the struct properties inside the function
    theStruct.a = 10;
    theStruct.b = true;
    Console.WriteLine($"{theStruct.a}, {theStruct.b}");
}

// TODO: Create an object instance of a class (which is a reference type)



// Perform an operation on the class
void ClassOp(MyClass theClass) {
    // Modify some of the properties of the class inside the function
    theClass.a = 10;
    theClass.b = true;
    Console.WriteLine($"{theClass.a}, {theClass.b}");
}


// These are declared at the bottom of the file because C# requires
// top-level statements to come before type declarations
class MyClass {
    public int a;
    public bool b;
}

struct s {
    public int a;
    public bool b;
}


