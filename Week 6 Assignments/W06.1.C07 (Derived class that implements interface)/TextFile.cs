public class TextFile : File, IPrintable
{
    public string? Contents { get; set; }

    public TextFile(string n, string c) : base(n + ".txt")
    {
        Contents = c;
    }

    public void Print() => Console.WriteLine(Contents);
}