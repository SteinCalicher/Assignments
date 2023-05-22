public static class Converter
{
    public static T2 ConvertVariables<T1, T2>(T1 input)
    {
        return (T2)Convert.ChangeType(input, typeof(T2));
    }
}