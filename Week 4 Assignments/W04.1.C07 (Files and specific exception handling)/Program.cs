﻿using Newtonsoft.Json;
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
            FileName = @"People.json";
        }
        catch(FileNotFoundException e)
        {
            Console.WriteLine($"Missing JSON File. {e.Message}");
        }
        
        using (StreamReader sr = new(FileName))
        {
            try
            {
                string JsonString = sr.ReadToEnd();
                List<Person> ListOfPersons = JsonConvert.DeserializeObject<List<Person>>(JsonString)!;
                return ListOfPersons;
            }
            catch(JsonReaderException e)
            {
                Console.WriteLine($"Invalid JSON. {e.Message}");
                return null;
            }
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