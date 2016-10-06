using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Authorization;
using Abp.AutoMapper;
using GlobalERP.Sessions.Dto;

namespace GlobalERP.Sessions
{
    [AbpAuthorize]
    public class SessionAppService : GlobalERPAppServiceBase, ISessionAppService
    {
        [DisableAuditing]
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            var output = new GetCurrentLoginInformationsOutput
            {
                User = (await GetCurrentUserAsync()).MapTo<UserLoginInfoDto>()
            };

            if (AbpSession.TenantId.HasValue)
            {
                output.Tenant = (await GetCurrentTenantAsync()).MapTo<TenantLoginInfoDto>();
            }

            return output;
        }
    }
}