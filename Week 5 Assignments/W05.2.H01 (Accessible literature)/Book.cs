public class Book : Publication
{
    public string? ISBN;
    public string? Currency;
    public double Price;
    public string? Author;

    public Book(string isbn, string title, string author, string publisher, List<string> audience) : base(title, publisher, "Book", audience)    
    {
        ISBN = isbn;
        Author = author;
    }

    public void SetPrice(int p, string ct)
    {
        if (p > 0)
        {
            Price = p;
            Currency = ct;
        }
    }

    public bool IsSuitableForChild()
    {
        if (Audience.Contains("Children")) return true;
        return false;
    }

    public override string ToString() => $"{Author}, ISBN: {ISBN}, {Title}, {Pages} pages, {PublishedOn}, {Currency} {Math.Floor(Price)}";
}