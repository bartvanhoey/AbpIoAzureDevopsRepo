using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpIoAzureDevops.Data
{
    /* This is used if database provider does't define
     * IAbpIoAzureDevopsDbSchemaMigrator implementation.
     */
    public class NullAbpIoAzureDevopsDbSchemaMigrator : IAbpIoAzureDevopsDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}