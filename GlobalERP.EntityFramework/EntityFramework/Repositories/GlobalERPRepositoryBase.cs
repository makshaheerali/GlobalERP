using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace GlobalERP.EntityFramework.Repositories
{
    public abstract class GlobalERPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<GlobalERPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected GlobalERPRepositoryBase(IDbContextProvider<GlobalERPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class GlobalERPRepositoryBase<TEntity> : GlobalERPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected GlobalERPRepositoryBase(IDbContextProvider<GlobalERPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
