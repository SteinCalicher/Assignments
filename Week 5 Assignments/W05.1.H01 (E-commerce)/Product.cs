class Product
{
    public string? Name;
    public double Price;
    public int Stock;

    public Product(string n, double p, int s)
    {
        Name = n;
        Price = p;
        Stock = s;
    }

    public virtual void Sell(int i)
    {
        if (i <= Stock)
        {
            Stock -= i;
            Console.WriteLine($"{i} units of {Name} have been sold.");
        }
        else Console.WriteLine($"{Name} is out of stock.");
    }

    public override string ToString() => $"Name: {Name}; price: {Price}; stock: {Stock}";
}