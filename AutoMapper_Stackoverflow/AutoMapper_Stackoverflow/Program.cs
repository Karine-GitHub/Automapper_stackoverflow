using AutoMapper;
using AutoMapper.EquivalencyExpression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Oncolin.Entities;
using Oncolin.Model;
using Oncolin.Model.Oncology;
using System;
using System.IO;

namespace AutoMapper_Stackoverflow
{
    class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((ctx, cfg) =>
                {
                    cfg.SetBasePath(Directory.GetCurrentDirectory());
                })
                .ConfigureServices((ctx, services) =>
                {
                    services.AddHostedService<Worker>();
                    services.AddLogging(cfg =>
                    {
                        cfg.AddConsole();
                        cfg.AddDebug();
                    });

                    services.AddAutoMapper(cfg =>
                    {
                        cfg.AddCollectionMappers();
                        cfg.AddProfile<ModelProfile>();
                    }, typeof(BaseModel).Assembly, typeof(IEntity).Assembly);
                });
    }
}
