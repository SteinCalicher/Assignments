public class ListWrapper<T>
{
    private T _mylist
    {
        get
        {
            return _mylist;
        }
        set
        {
            List<T> _mylist = new List<T>( );
        }
    }

    public void Add(T parameter)
    {
        _mylist.Add(parameter);
    }
}