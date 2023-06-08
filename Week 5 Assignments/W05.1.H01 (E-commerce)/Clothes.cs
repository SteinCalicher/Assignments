class Clothes : Product
{
    public string? Size;
    public string? Material;

    public Clothes(string n, double p, int s, string sz, string m) : base(n, p, s)
    {
        Size = sz;
        Material = m;
    }

    public override string ToString() => $"Name: {Name}; price: {Price}; stock: {Stock}; size: {Size}; material: {Material}";
}