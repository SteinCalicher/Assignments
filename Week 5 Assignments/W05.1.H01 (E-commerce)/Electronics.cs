class Electronics :  Product
{
    public string? Brand;
    public string? Model;
    private static int MinimumStock;

    public Electronics(string n, double p, int s, string b, string m) : base(n, p, s)
    {
        Brand = b;
        Model = m;
        MinimumStock = 10;
    }

    public override void Sell(int i)
    {
        base.Sell(i);
        Restock();
    }

    public virtual void Restock() => Stock = MinimumStock;

    public override string ToString() => $"Name: {Name} ({Brand} {Model}); price: {Price}; stock: {Stock}";
}