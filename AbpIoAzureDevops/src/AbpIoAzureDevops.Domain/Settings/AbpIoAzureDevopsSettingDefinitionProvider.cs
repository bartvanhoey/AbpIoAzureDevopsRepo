using Volo.Abp.Settings;

namespace AbpIoAzureDevops.Settings
{
    public class AbpIoAzureDevopsSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpIoAzureDevopsSettings.MySetting1));
        }
    }
}
