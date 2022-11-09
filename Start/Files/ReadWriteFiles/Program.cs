// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Reading and Writing data from and to files

// Make sure the example file exists
const string filename = "TestFile.txt";

// TODO 1: WriteAllText overwrites a file with the given content
if (!File.Exists(filename)) {
    File.WriteAllText(filename, "Argh!!");
}

// TODO 3: AppendAllText adds text to an existing file
File.AppendAllText(filename, "No, Do zobczenia");

// TODO 4: A FileStream can be opened and written to until closed
using (StreamWriter sw = File.AppendText(filename))
{
    sw.WriteLine("Puede ser");
    sw.WriteLine("Puede ser1");
    sw.WriteLine("Puede ser2");
}

// TODO 2: ReadAllText reads all the content from a file
string contenido;
contenido = File.ReadAllText(filename);
Console.WriteLine(contenido);
