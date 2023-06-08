public static class CleaningService
{
    public static void Clean(ICleanable i)
    {
        i.Clean();
    }

    public static void Clean(List<ICleanable> ListOfI)
    {
        foreach (ICleanable i in ListOfI)
        {
            i.Clean();
        }
    }
}