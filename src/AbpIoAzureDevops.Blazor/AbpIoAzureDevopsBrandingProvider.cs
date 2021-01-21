using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpIoAzureDevops.Blazor
{
  [Dependency(ReplaceServices = true)]
  public class AbpIoAzureDevopsBrandingProvider : DefaultBrandingProvider
  {
    public override string AppName => "ABP Framework to Azure";
  }
}
