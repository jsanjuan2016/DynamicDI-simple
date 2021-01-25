using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DynamicDependencyInjectionNoParams
{
    static class Program
    {
        static Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            using IServiceScope serviceScope = host.Services.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;
            WindowManager windowManager = provider.GetRequiredService<WindowManager>();
            windowManager.Show();

            return host.RunAsync();
        }
        static IHostBuilder CreateHostBuilder(string[] args) 
        {
            return Host.CreateDefaultBuilder(args).ConfigureServices((context, services) => ConfigureServices(services));
        }

        static IServiceCollection ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IShape<Rectangle>, Rectangle>();
            services.AddTransient<IShape<Circle>, Circle>();
            services.AddTransient<WindowManager>();

            return services;
        }
    }
}
