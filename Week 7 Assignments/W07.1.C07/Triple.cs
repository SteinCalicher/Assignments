public class Triple<T1, T2, T3> : Pair<T1, T2>
{
    public T3? Trd{ get; private set; }

    public Triple(T1 FST, T2 SND, T3 TRD) : base(FST, SND)
    {
        Trd = TRD;
    }
}