class Program
{
    static void Main()
    {
        string FileName = @"MyTextFile.txt";
        var addedLine = "\nHet is een Razer BlackWidow V3 Mini X Hyperspeed.\nIk heb hem kunnen kopen voor 84,95 i.p.v de normale prijs van 160,-.";
        File.AppendAllText(FileName, addedLine);
        Console.WriteLine(File.ReadAllText(FileName));
    }
}