namespace ASPNETAPP_6;

public static class StartupExtension
{
    public static WebApplicationBuilder UseStartup<T>(this WebApplicationBuilder builder) where T : IStartup
    {
        var startup = Activator.CreateInstance(typeof(T), builder.Configuration) as IStartup;
        if (startup is null) throw new ArgumentNullException("Classe de Startup inválida!");
        
        startup.ConfigureServices(builder.Services);
        
        var app = builder.Build();
        startup.Configure(app, app.Environment);
        
        app.Run();

        return builder;
    }
}