using AbpIoAzureDevops.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpIoAzureDevops.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpIoAzureDevopsController : AbpController
    {
        protected AbpIoAzureDevopsController()
        {
            LocalizationResource = typeof(AbpIoAzureDevopsResource);
        }
    }
}