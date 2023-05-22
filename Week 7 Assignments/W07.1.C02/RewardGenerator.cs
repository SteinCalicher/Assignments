public static class RewardGenerator
{
    static Random r = new Random();

    public static T GetRandomElement<T>(List<T> L)
    {
        return L[r.Next(L.Count)];
    }
}
