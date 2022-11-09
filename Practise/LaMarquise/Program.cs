
string curpath = Directory.GetCurrentDirectory();
int totaldirs = 0;
int excel = 0;
int word = 0;
int ppt = 0;
long totalPeso = 0;
long excelPeso = 0;
long wordPeso = 0;
long pptPeso = 0;
Console.WriteLine(curpath);

string pathAUsar = "";


List<string> thedirs = new List<string>(Directory.EnumerateDirectories(curpath));
foreach (string dir in thedirs)
{
    if (dir.Contains("FileCollection"))
    {
        pathAUsar = dir;
    }
}


List<string> thefiles = new List<string>(Directory.EnumerateFiles(pathAUsar));
foreach (string file in thefiles)
{

    try
        {
            FileInfo fi = new FileInfo(file);
            
            if (file.Contains(".docx"))
            {
                word = word + 1;
                wordPeso = wordPeso + fi.Length;
            }
            if (file.Contains(".pptx"))
            {
                ppt = ppt + 1;
                pptPeso = pptPeso + fi.Length;
            }
            if (file.Contains(".xlsx"))
            {
                excel = excel + 1;
                excelPeso = excelPeso + fi.Length;
            }
            totaldirs = totaldirs + 1;
            totalPeso = wordPeso + fi.Length;
            
            
            
            
        }
    catch (System.Exception){
            throw;
        }
   
}
totalPeso = pptPeso + wordPeso + excelPeso;
totaldirs = ppt + word + excel;





if (File.Exists("results.txt")){
    File.Delete("results.txt");
}
if (!File.Exists("results.txt")){

    using (StreamWriter sw = File.CreateText("results.txt"))
{
    
sw.WriteLine($"Peso total: {totalPeso}");
sw.WriteLine($"Peso Powerpoint: {pptPeso}");
sw.WriteLine($"Peso Word: {wordPeso}");
sw.WriteLine($"Peso Excel: {excelPeso}");

sw.WriteLine($"Archivos totales: {totaldirs}");
sw.WriteLine($"Powerpoints: {ppt}");
sw.WriteLine($"Words: {word}");
sw.WriteLine($"Excels: {excel}");
}
}



