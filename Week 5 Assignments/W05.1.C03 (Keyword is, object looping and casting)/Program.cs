class Program
{
    public static void Main()
    {
        Person john = new("John Doe");
        Student jane = new("Jane Doe");
        List<Person> L1 = new() {john, jane};

        foreach (Person p in L1)
        {
            Console.WriteLine(p.Introduce());
            if (p is Student)
            {
                var s = (Student) p;
                Console.WriteLine(s.Status());
            }
        }
    }
}