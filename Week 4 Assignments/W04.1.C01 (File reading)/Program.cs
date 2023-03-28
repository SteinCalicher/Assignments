class Program
{
    static void Main()
    {
        var Path = @"TextFile1.txt";
        var text = File.ReadAllText(Path);
        Console.WriteLine(text);
    }
}