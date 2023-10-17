using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("WebAPI2023")]

namespace Infrastructure.CustomerConfiguration;

internal class AddConfigurations : IHostingStartup
{
    public void Configure(IWebHostBuilder builder)
    {
        var dictionary = new Dictionary<string, string>
        {
            { "TestParameter", "XXAXX" }
        };

        builder.ConfigureAppConfiguration((host, config) =>
        {
            // host.HostingEnvironment.ContentRootPath 可能是專案架構的問題，不是web所以讀不到。
            string currentPath = Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.FullName;
            string path = $"{currentPath}\\WebAPI2023\\Infrastructure\\CustomerConfiguration\\";

            config
            .AddJsonFile($"{path}/settings/googleSettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"{path}/settings/googleSettings.Product.json", optional: false, reloadOnChange: true);
            //.AddJsonFile($"{path}/settings/settings.{host.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true);

            config
            .AddInMemoryCollection(dictionary!);
        });
    }
}