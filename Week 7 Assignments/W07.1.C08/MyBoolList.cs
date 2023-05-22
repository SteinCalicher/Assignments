public class MyBoolList : MyGenericList<bool>
{
    public MyBoolList(List<bool> elems) : base(elems) { }
    public override bool Combine()
    {
        foreach (var elem in Elems)
        {
            if (!elem) return false;
        }
        return true;
    }
}