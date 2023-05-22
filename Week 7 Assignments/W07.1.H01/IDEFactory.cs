public class IDEFactory : IFactory<IDE>
{
    public IDE CreateLightTheme()
    {
        IDE LightThemeIDE = new IDE("White", "Black", "Light blue");
        return LightThemeIDE;
    }

    public IDE CreateDarkTheme()
    {
        IDE DarkThemeIDE = new IDE("Black", "White", "Light yellow");
        return DarkThemeIDE;
    }
}