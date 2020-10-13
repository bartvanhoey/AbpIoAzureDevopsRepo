using AbpIoAzureDevops.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpIoAzureDevops.Permissions
{
    public class AbpIoAzureDevopsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpIoAzureDevopsPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpIoAzureDevopsPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpIoAzureDevopsResource>(name);
        }
    }
}
