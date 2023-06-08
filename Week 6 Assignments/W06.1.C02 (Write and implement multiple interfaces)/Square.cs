public class Square : IDrawable, IResizable
{
    public int Size { get; private set; }
    public Square(int size) => Size = size;
    public void Draw()
    {
        for (int i = 0; i < Size; i++)
        {
            string DrawnLine = new string('*', Size);
            Console.WriteLine(DrawnLine);
        }
        Console.WriteLine();
    }
    public void Resize(double scale)
    {
        Double Rize = Size * scale;
        Math.Round(Rize);
        Size = (int)Rize;
    }
}