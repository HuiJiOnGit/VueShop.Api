using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VueShop.IRepository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> QueryById(object id);

        Task<List<TEntity>> QueryByIds(object[] ids);

        Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression);

        Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, Expression<Func<TEntity, object>> orderExpression, bool isAsc);

        Task<int> Add(TEntity entity);

        Task<int> Add(List<TEntity> entities);

        Task<bool> DeleteById(object id);

        Task<bool> DeleteByModel(TEntity entity);

        Task<bool> DeleteByIds(List<object> ids);

        Task<bool> Update(TEntity entity);
    }
}