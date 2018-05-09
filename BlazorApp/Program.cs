using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BlazorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                // Add any custom services here
                //https://blogs.msdn.microsoft.com/webdev/2018/03/22/get-started-building-net-web-apps-in-the-browser-with-blazor/
                //https://blogs.msdn.microsoft.com/webdev/2018/04/17/blazor-0-2-0-release-now-available/
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
