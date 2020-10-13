using AbpIoAzureDevops.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpIoAzureDevops
{
    [DependsOn(
        typeof(AbpIoAzureDevopsEntityFrameworkCoreTestModule)
        )]
    public class AbpIoAzureDevopsDomainTestModule : AbpModule
    {

    }
}