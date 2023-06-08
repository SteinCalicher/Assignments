class Program
{
    public static void Main()
    {
        Person P1 = new("John Doe");
        Student S1 = new("Jane Doe");

        Console.WriteLine(P1.Introduce());
        Console.WriteLine(S1.Introduce());
        Console.WriteLine(S1.Status());
        S1.Graduate();
        Console.WriteLine(S1.Status());
    }
}