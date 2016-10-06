using System.Threading.Tasks;
using Abp.Application.Services;
using GlobalERP.Roles.Dto;

namespace GlobalERP.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
