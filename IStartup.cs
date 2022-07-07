namespace ASPNETAPP_6;

public interface IStartup
{
    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services);
    public void Configure(WebApplication app, IWebHostEnvironment environment);
}