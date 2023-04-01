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
        string FileName = null;
        try
        {
            FileName = @"People.json";
        }
        catch(FileNotFoundException e)
        {
            Console.WriteLine($"Missing JSON File. {e.Message}");
        }
        
        using (StreamReader sr = new(FileName))
        {
            List<Person> ListOfPersons = null;
            try
            {
                string JsonString = sr.ReadToEnd();
                ListOfPersons = JsonConvert.DeserializeObject<List<Person>>(JsonString)!;
            }
            catch(JsonReaderException e)
            {
                Console.WriteLine($"Invalid JSON. {e.Message}");
            }
            return ListOfPersons;
        }
    }

    public static void FileWriter(List<Person> Input)
    {
        var FileName = @"People.json";
        using (StreamWriter sw = new(FileName))
        {
            var List2Json = JsonConvert.SerializeObject(Input);
            sw.Write(List2Json);
        }
    }
}