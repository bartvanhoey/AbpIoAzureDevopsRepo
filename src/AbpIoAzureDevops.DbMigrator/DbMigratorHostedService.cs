using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AbpIoAzureDevops.Data;
using Serilog;
using Volo.Abp;
using Microsoft.Extensions.Configuration;
using System;

namespace AbpIoAzureDevops.DbMigrator
{
  public class DbMigratorHostedService : IHostedService
  {
    private readonly IHostApplicationLifetime _hostApplicationLifetime;

    public DbMigratorHostedService(IHostApplicationLifetime hostApplicationLifetime)
    {
      _hostApplicationLifetime = hostApplicationLifetime;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
      using (var application = AbpApplicationFactory.Create<AbpIoAzureDevopsDbMigratorModule>(options =>
      {
        options.UseAutofac();
        options.Services.AddLogging(c => c.AddSerilog());

        // Add this line of code to make it possible read from appsettings.Staging.json
        options.Services.ReplaceConfiguration(BuildConfiguration());

      }))
      {
        application.Initialize();

        await application
            .ServiceProvider
            .GetRequiredService<AbpIoAzureDevopsDbMigrationService>()
            .MigrateAsync();

        application.Shutdown();

        _hostApplicationLifetime.StopApplication();
      }
    }

    private static IConfiguration BuildConfiguration()
    {
      var configurationBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json");

      // Extra code block to make it possible to read from appsettings.Staging.json
      var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
      if (environmentName == "Staging")
      {
        configurationBuilder.AddJsonFile($"appsettings.{environmentName}.json", true);
      }

      return configurationBuilder
          .AddEnvironmentVariables()
          .Build();
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
  }
}
