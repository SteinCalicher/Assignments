using Newtonsoft.Json;

class Program
{
    public static void Main()
    {
        List<Car> ListOfCars = FileReader();
        foreach (Car car in ListOfCars)
        {
            for (int i = 0; i < 5;i++)
            {
                car.Drive();
            }
        }
        FileWriter(ListOfCars);
    }
    
    public static List<Car> FileReader()
    {
        var FileName = @"Cars.json";
        using(StreamReader sr = new (FileName))
        {
            string File2Json = sr.ReadToEnd();
            List<Car> ListOfObjects = JsonConvert.DeserializeObject<List<Car>>(File2Json)!;
            return ListOfObjects;
        }
    }

    public static void FileWriter(List<Car> input)
    {   
        var FileName = @"Cars.json";
        using (StreamWriter sw = new(FileName))
        {
            var List2Json = JsonConvert.SerializeObject(input);
            sw.Write(List2Json);
        }
    }
}