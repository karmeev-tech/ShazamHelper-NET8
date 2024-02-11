namespace MetaMusic.Integrations;

public static class AppConfig
{
    public static void AddJsonConfig(this WebApplicationBuilder builder, string env = "")
    {
        builder.Configuration
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: true);
    }
}