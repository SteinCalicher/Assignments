public class Dog : Animal
{
    public Dog(string n) : base(n)
    {
        Sound = "Woof!";
    }

    public void Fetch()
    {
        Console.WriteLine($"{Name} fetches the stick");
    }

}