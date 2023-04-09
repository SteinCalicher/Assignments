public class Cat : Animal
{
    public Cat(string n) : base(n)
    {
        Sound = "Meow!";
    }

    public void Climb()
    {
        Console.WriteLine($"{Name} climbs the curtains");
    }

}