using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace ElectronVueDesktopToolApi.EntityFramework.Core;

[AppDbContext("Server=localhost;database=mech_tool;uid=root;pwd=woshishui;", DbProvider.MySqlOfficial)]
public class DefaultDbContext : AppDbContext<DefaultDbContext>
{
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
    {
    }
}
