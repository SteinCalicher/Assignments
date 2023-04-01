public class Person
{
    public string Name;
    public int Age;
    public Person(string name, int age): this(name)
    {
        this.Age = age;
    }

    public Person(string Name)
    {
        this.Name = Name;
        this.Age = 0;
    }
}