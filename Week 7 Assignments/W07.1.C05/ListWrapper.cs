public class ListWrapper<T>
{
    private List<T> _list;

    public ListWrapper() { _list = new List<T>(); }

    public void Add(T item) { _list.Add(item); }

    public T Get(int index) { return _list[index]; }

    public int Count { get { return _list.Count; } }

    public int HighestCount<T>(ListWrapper<T> L)
    {
        if (L.Count > this.Count)
            return L.Count;
        else
            return this.Count;
    }
}