using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GlobalERP.MultiTenancy.Dto;

namespace GlobalERP.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
