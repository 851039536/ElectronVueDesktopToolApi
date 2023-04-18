namespace ElectronVueDesktopToolApi.Application;

public class SystemService : ISystemService, ITransient
{
    public string GetDescription()
    {
        return "让 .2sssNET 开发更简单，更通用，更流行。";
    }
}
