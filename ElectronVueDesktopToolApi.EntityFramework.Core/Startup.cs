using Furion;
using Microsoft.Extensions.DependencyInjection;

namespace ElectronVueDesktopToolApi.EntityFramework.Core;

public class Startup : AppStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDatabaseAccessor(options =>
        {
            options.AddDbPool<DefaultDbContext>();
        }, "ElectronVueDesktopToolApi.Database.Migrations");
    }
}
