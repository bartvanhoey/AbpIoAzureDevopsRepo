using AbpIoAzureDevops.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpIoAzureDevops.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpIoAzureDevopsEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpIoAzureDevopsApplicationContractsModule)
        )]
    public class AbpIoAzureDevopsDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
