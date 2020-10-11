using System;
using System.Collections.Generic;
using System.Text;
using AbpIoAzureDevops.Localization;
using Volo.Abp.Application.Services;

namespace AbpIoAzureDevops
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpIoAzureDevopsAppService : ApplicationService
    {
        protected AbpIoAzureDevopsAppService()
        {
            LocalizationResource = typeof(AbpIoAzureDevopsResource);
        }
    }
}
