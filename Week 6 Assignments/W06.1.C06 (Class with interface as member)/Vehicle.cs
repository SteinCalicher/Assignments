public class Vehicle
{
    public string? Make{ get; set; }
    public string? Model{ get; set; }
    public IEngine? Engine{ get; set; }

    public Vehicle(string M1, string M2, IEngine E)
    {
        Make = M1;
        Model = M2;
        Engine = E;
    }
}