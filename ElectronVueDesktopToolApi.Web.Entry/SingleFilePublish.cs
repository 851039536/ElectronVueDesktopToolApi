using Furion;
using System.Reflection;

namespace ElectronVueDesktopToolApi.Web.Entry;

public class SingleFilePublish : ISingleFilePublish
{
    public Assembly[] IncludeAssemblies()
    {
        return Array.Empty<Assembly>();
    }

    public string[] IncludeAssemblyNames()
    {
        return new[]
        {
            "ElectronVueDesktopToolApi.Application",
            "ElectronVueDesktopToolApi.Core",
            "ElectronVueDesktopToolApi.EntityFramework.Core",
            "ElectronVueDesktopToolApi.Web.Core"
        };
    }
}