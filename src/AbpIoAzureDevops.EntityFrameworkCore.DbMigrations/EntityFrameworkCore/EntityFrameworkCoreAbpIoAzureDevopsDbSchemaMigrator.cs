using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpIoAzureDevops.Data;
using Volo.Abp.DependencyInjection;

namespace AbpIoAzureDevops.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpIoAzureDevopsDbSchemaMigrator
        : IAbpIoAzureDevopsDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpIoAzureDevopsDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpIoAzureDevopsMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpIoAzureDevopsMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}