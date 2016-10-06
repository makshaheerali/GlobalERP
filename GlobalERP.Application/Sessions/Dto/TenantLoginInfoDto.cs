using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using GlobalERP.MultiTenancy;

namespace GlobalERP.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}