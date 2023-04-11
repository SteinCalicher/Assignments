public class Circle : Shape
{
    public double Radius{ get; set; }
    public override double Area{ get { return Math.PI * Math.Pow(Radius, 2.0);} }
    public override double Perimeter{ get { return (2 * Math.PI) * Radius; } }
    
    public Circle(double r) => Radius = r;

    public override string Info() => $"Circle with a radius of {Radius}";
}
