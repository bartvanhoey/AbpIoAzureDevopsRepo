﻿using Shouldly;
using System.Threading.Tasks;
using Volo.Abp.Identity;
using Xunit;

namespace AbpIoAzureDevops.Samples
{
    /* This is just an example test class. 
     */
    public class SampleAppServiceTests : AbpIoAzureDevopsApplicationTestBase
    {
        private readonly IIdentityUserAppService _userAppService;

        public SampleAppServiceTests()
        {
            _userAppService = GetRequiredService<IIdentityUserAppService>();
        }

        [Fact]
        public async Task Initial_Data_Should_Contain_Admin_User()
        {
            //Act
            var result = await _userAppService.GetListAsync(new GetIdentityUsersInput());

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(u => u.UserName == "admin");
        }
    }
}
