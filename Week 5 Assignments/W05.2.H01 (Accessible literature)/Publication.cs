public class Publication
{
    public string? Title;
    public string? Publisher;
    public string? PublicationType;
    protected List<string> Audience;
    public bool IsPublished
    {
        get
        {
            if (PublicationDate != null) return true;
            return false;
        }
    }

    private int _pages;
    private DateTime _datepublished;

    public Publication(string t, string p, string pt, List<string> a)
    {
        Title = t;
        Publisher = p;
        PublicationType = pt;
        Audience = a;
    }

    public int Pages
    {
        get{ return _pages; }
        set{ if (value > 0) _pages = value; }
    }

    public DateTime PublicationDate{ get{ return _datepublished; } set{ _datepublished = value; }  }
    public virtual string PublishedOn
    {
        get
        {
            if (_datepublished != null) return _datepublished.ToString();
            return "not published yet";
        }
    }

    public bool IsSuitableForAudience(string s)
    {
        if (Audience.Contains(s)) return true;
        return false;
    }

    public override string ToString() => $"{Title}, {Pages} pages, {PublishedOn}";
}