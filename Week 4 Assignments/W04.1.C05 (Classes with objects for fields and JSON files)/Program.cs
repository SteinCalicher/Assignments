using Newtonsoft.Json;
class Program
{
    public static void Main()
    {
        List<Person> ListOfPeople = FileReader();
        foreach(Person person in ListOfPeople)
        {
            foreach(Car car in person.OwnedCars)
            {
                for(int i = 0; i < 5;i++)
                {
                    car.Drive();
                }
            }
        }
        FileWriter(ListOfPeople);
    }

    public static List<Person> FileReader()
    {
        var FileName = @"People.json";
        try
        {    
            using (StreamReader sr = new(FileName))
            {
                string JsonString = sr.ReadToEnd();
                List<Person> ListOfPersons = JsonConvert.DeserializeObject<List<Person>>(JsonString)!;
                return ListOfPersons;
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }

    }

    public static void FileWriter(List<Person> Input)
    {
        var FileName = @"People.json";
        try
        {
            using (StreamWriter sw = new(FileName))
            {
                var List2Json = JsonConvert.SerializeObject(Input);
                sw.Write(List2Json);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}