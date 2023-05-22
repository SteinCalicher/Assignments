public class KeyValuePair<T>
{
    public T? Key { get; set; }
    public T? Value { get; set; }

    public KeyValuePair(T key, T value)
    {
        Key = key;
        Value = value;
    }
}