internal class Program
{
    private static void Main(string[] args)
    {
        BankAccount b1 = new(300);
        Console.WriteLine(b1.Withdraw(250));
        Console.WriteLine(b1.ReadBalance());
    }
}