public class Cruiser : Motorcycle
{
    public int Seatheight;
    public Cruiser(string make, string model, int year, int seatheight): base(make, model, year)
    {
        Seatheight = seatheight;
    }

    public override string Ride() => base.Ride() + $" with a seat height of {Seatheight} cm";
}