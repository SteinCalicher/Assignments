public class Employee : IPayable
{
    public string Name{ get; set; }
    public double Salary { get; set; }
    public int EmployeeId { get; set; }
    public static int EmployeeCounter = 0;
    public string Info{ get; } 

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
        EmployeeId = ++EmployeeCounter;
        Info = $"ID: {EmployeeId} ({Name}); {Salary}/month";
    }

    public double GetPaymentAmount()
    { return Salary; }
}