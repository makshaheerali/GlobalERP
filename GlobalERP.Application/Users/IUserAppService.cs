using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GlobalERP.Users.Dto;

namespace GlobalERP.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);

        Task<ListResultDto<UserListDto>> GetUsers();
        Task<UserListDto> GetUser(GetUserInput input);
        Task CreateUser(CreateUserInput input);
    }
}