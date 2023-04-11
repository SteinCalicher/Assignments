public class Square : Shape
{
    public double Length{ get; set; }
    public override double Area{ get { return Math.Pow(Length, 2.0);} }
    public override double Perimeter{ get { return Length * 4; } }
    
    public Square(double l) => Length = l;

    public override string Info() => $"Square with sides of {Length}";
}