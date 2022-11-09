// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Working with file information

// Make sure the example file exists
const string filename = "A.Z.G.E.D.A..txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
    }
}

// TODO: Get some information about the file
Console.WriteLine(File.GetCreationTime(filename));
Console.WriteLine(File.GetLastWriteTime(filename));
Console.WriteLine(File.GetLastAccessTime(filename));


File.SetAttributes(filename, FileAttributes.Normal);
Console.WriteLine(File.GetAttributes(filename));


// TODO: We can also get general information using a FileInfo 
try
{
    FileInfo fi = new FileInfo(filename);
    Console.WriteLine($"{fi.Length}");
    Console.WriteLine($"{fi.Directory}");
    Console.WriteLine($"{fi.IsReadOnly}");

}
catch (System.Exception)
{
    
    throw;
}

// TODO: File information can also be manipulated

DateTime dt = new DateTime(2077, 7, 13, 13, 23, 21);
DateTime dt2 = new DateTime(2077, 7, 14, 10, 11, 09);
File.SetCreationTime(filename, dt);
File.SetLastAccessTime(filename, dt2);
File.SetLastWriteTime(filename, dt2);

Console.WriteLine(File.GetCreationTime(filename));