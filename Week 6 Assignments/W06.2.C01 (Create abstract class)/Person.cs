public abstract class Person
{
    public int Age{ get; set; }
    public abstract string? FirstName{ get; set; }
    public abstract string? LastName{ get; set; }

    protected Person(string f, string l, int a)
    {
        FirstName = f;
        LastName = l;
        Age = a;
    }

    public abstract string Greet();

    public virtual string GetFullName() => $"{FirstName} {LastName}";
}