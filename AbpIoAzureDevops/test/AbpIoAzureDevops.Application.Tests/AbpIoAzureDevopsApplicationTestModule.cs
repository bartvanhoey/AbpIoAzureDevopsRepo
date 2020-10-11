using Volo.Abp.Modularity;

namespace AbpIoAzureDevops
{
    [DependsOn(
        typeof(AbpIoAzureDevopsApplicationModule),
        typeof(AbpIoAzureDevopsDomainTestModule)
        )]
    public class AbpIoAzureDevopsApplicationTestModule : AbpModule
    {

    }
}