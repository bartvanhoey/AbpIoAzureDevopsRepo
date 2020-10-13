using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpIoAzureDevops.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpIoAzureDevopsEntityFrameworkCoreModule)
        )]
    public class AbpIoAzureDevopsEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpIoAzureDevopsMigrationsDbContext>();
        }
    }
}
