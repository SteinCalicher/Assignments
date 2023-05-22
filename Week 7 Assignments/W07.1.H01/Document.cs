public class Document
{
    public string? Backgroundcolor { get; set; }
    public string? Fontcolor { get; set; }

    public Document(string? backgroundcolor, string? fontcolor)
    {
        Backgroundcolor = backgroundcolor;
        Fontcolor = fontcolor;
    }
}