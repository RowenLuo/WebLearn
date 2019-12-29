using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DILearn
{
    public interface ITransient { }
    public class Transient : ITransient { }

    public interface ISingleton { }
    public class Singleton : ISingleton { }

    public interface IScoped { }
    public class Scoped : IScoped { }

    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<ITransient, Transient>();
            services.AddSingleton<ISingleton, Singleton>();
            services.AddScoped<IScoped, Scoped>();
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            Console.WriteLine(ReferenceEquals(
                serviceProvider.GetService<ITransient>(),
                serviceProvider.GetService<ITransient>()
            ));

            Console.WriteLine(ReferenceEquals(
                serviceProvider.GetService<ISingleton>(),
                serviceProvider.GetService<ISingleton>()
            ));

            Console.WriteLine(ReferenceEquals(
                serviceProvider.GetService<IScoped>(),
                serviceProvider.GetService<IScoped>()
            ));

            IServiceProvider serviceProvider1 = serviceProvider.CreateScope().ServiceProvider;
            IServiceProvider serviceProvider2 = serviceProvider.CreateScope().ServiceProvider;

            Console.WriteLine(ReferenceEquals(
                serviceProvider1.GetService<IScoped>(),
                serviceProvider2.GetService<IScoped>()
            ));

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
