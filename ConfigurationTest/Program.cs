using Autofac;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = BuildConfig(args);
            var container = BuildContainer(configuration);

            var needOptions = container.Resolve<NeedsOptions>();

            var nestedOptions = configuration.GetSection("nested").Get<NestedOptions>();

            Console.WriteLine(nestedOptions.One);

            Console.WriteLine(configuration["value"]);
            Console.WriteLine(configuration["test"]);

            var nestedConfiguration = configuration.GetSection("nested");
            
            Console.WriteLine(nestedConfiguration["one"]);
            Console.WriteLine(nestedConfiguration["two"]);

            Console.Read();
        }

        static ILifetimeScope BuildContainer(IConfigurationRoot configuration)
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterInstance(configuration)
                .As<IConfigurationRoot>();

            containerBuilder.RegisterInstance(configuration.GetSection("nested").Get<NestedOptions>())
                .AsSelf();

            containerBuilder.RegisterType<NeedsOptions>()
                .AsSelf();

            return containerBuilder.Build();
        }

        static IConfigurationRoot BuildConfig(string[] args)
        {
            return new ConfigurationBuilder()
                .Add(new AppSettingsConfigurationSource())
                .AddEnvironmentVariables("CT_")
                .AddCommandLine(args, new Dictionary<string, string>
                {
                    { "--test", "test" },
                    { "-t", "test" },
                    { "-v", "value" }
                })
                .Build();
        }
    }
}
