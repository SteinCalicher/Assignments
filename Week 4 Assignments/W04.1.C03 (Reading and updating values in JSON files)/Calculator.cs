using Newtonsoft.Json;

public static class Calculator{
    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;
    public static double Divide(double a, double b) => a / b;
    public static double Modulo(double a, double b) => a % b;
    public static void StoreInMemory(double Input)
    {
        var FileName = @"Memory.json";
        using (var sw = new StreamWriter(FileName))
        {
            sw.Write(JsonConvert.SerializeObject(Input));
        }
    }
    public static double RestoreFromMemory()
    {
        var FileName = @"Memory.json";
        using (var sr = new StreamReader(FileName))
        {
            string jsonString = sr.ReadToEnd();
            var FromJson = JsonConvert.DeserializeObject<double>(jsonString)!;
            return FromJson;
        }
    }
}