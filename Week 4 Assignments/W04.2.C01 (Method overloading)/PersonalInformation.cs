public static class PersonalInformation
{
    public static void PrintName(string input)
    {
        Console.WriteLine(input);
    }

    public static void PrintName(string input1, string input2)
    {
        Console.WriteLine($"{input1} {input2}");
    }

    public static void PrintName(char input1, string input2)
    {
        Console.WriteLine($"{input1}. {input2}");
    }

    public static int IncreaseSalary(int int1)
    {
        int1 += 100;
        return int1;
    }

    public static double IncreaseSalary(int int1, double double1)
    {
        double intReturn = int1 * (1 + double1);
        return intReturn;
    }
}