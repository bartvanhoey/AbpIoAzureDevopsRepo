using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpIoAzureDevops.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AbpIoAzureDevopsHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpIoAzureDevopsConsoleApiClientModule : AbpModule
    {
        
    }
}
