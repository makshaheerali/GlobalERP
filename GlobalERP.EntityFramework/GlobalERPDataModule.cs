using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using GlobalERP.EntityFramework;

namespace GlobalERP
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(GlobalERPCoreModule))]
    public class GlobalERPDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<GlobalERPDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
