using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpIoAzureDevops.EntityFrameworkCore
{
    public static class AbpIoAzureDevopsDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpIoAzureDevops(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpIoAzureDevopsConsts.DbTablePrefix + "YourEntities", AbpIoAzureDevopsConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}