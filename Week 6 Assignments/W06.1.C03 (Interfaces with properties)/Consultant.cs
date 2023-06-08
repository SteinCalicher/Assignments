public class Consultant : IPayable
{
    public string Name{ get; set; }
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }
    public string Info{ get; }

    public Consultant(string name, double hourlyRate)
    {
        Name = name;
        HourlyRate = hourlyRate;
        Info = $"{Name}; {HourlyRate}/hour";
    }

    public double GetPaymentAmount()
    { return HourlyRate * HoursWorked; }
}