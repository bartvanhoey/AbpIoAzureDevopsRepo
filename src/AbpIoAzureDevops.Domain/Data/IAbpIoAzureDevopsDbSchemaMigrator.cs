using System.Threading.Tasks;

namespace AbpIoAzureDevops.Data
{
    public interface IAbpIoAzureDevopsDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
