using static System.Formats.Asn1.AsnWriter;

public class Program
{
    public static void Main()
    {
        //Retrieving employees from a database or a file
        List<object> employees = new()
        {
            new Employee(1, "Miles Dyson", "Developer"),
            new Employee(2, "Coleman Reese", "Lawyer"),
            new Manager (3, "Bill Lumbergh", "Manager", 5),
            new Manager (4, "Michael Scott", "Manager", 10),
            new Dog("Owney the mascot dog") //Not an employee
        };
        ListDirectReports(employees);
    }

    public static void ListDirectReports(List<object> employees)
    {
        foreach (object e in employees)
        {
            Manager m = e as Manager;
            if (m != null)
            {
                Console.WriteLine($"{m.Position} {m.Name} has {m.DirectReportsCount} direct reports.");
            }
        }
    }
}