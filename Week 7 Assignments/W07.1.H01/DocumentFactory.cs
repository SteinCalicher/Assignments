public class DocumentFactory : IFactory<Document>
{
    public Document CreateLightTheme()
    {
        Document LightThemeDocument = new Document("White", "Black");
        return LightThemeDocument;
    }

    public Document CreateDarkTheme()
    {
        Document DarkThemeDocument = new Document("Black", "White");
        return DarkThemeDocument;
    }
}