class Computer : Electronics
{
    private static int MinimumStock;
    public Computer(string n, double p, int s, string b, string m) : base(n, p, s, b, m)
    {
        MinimumStock = 5;
    }

    public override void Restock() => Stock = MinimumStock;
}