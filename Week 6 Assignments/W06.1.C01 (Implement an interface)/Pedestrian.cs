public class Pedestrian : Person, ICommute
{
    public Pedestrian(string name) : base(name) { }
    public void Move(int i) => Console.WriteLine($"Walked {i} kms");
}