using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using netsatis.tables;
using netsatis.Context;
using System.Data.Entity;

namespace netsatis.Interfaces
{
    interface IEntityRepository<TContext,TEntity>
        where TContext:DbContext,new()
        where TEntity:class,IEntity,new()
    {
         bool AddOrUpdate(TContext context, TEntity entity);
        void Delete(TContext context, Expression<Func<TEntity, bool>> filter);
        void Save(TContext context);

    }
}
