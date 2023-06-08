public class Person
{
    private string? _firstname;
    private string? _lastname;

    public Person(string f, string l)
    {
        _firstname = f;
        _lastname = l;
    }

    public string? FullName
    {
        get
        {
            return $"{_firstname} {_lastname}";
        }
    }
}