public class Program
{
    public static void Main()
    {
        Employee e = new("John", "Doe", "john.doe@example.com");
        Manager m = new("Jane", "Doe", "jane.doe@example.com", "Sales");
        SalesPerson s = new("Bob", "Smith", "bob.smith@example.com", 100000);
        List<Employee> workers = new() {e, m, s};

        e.PrintEmployeeInfo();
        
        Employee em = m as Employee;
        em.PrintEmployeeInfo();

        Employee es = s as Employee;
        es.PrintEmployeeInfo();

        e.PrintEmployeeInfo();
        m.PrintEmployeeInfo();
        s.PrintEmployeeInfo();




    }
}