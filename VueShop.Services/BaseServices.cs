using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VueShop.IRepository;
using VueShop.IServices;

namespace VueShop.Services
{
    public class BaseServices<TEntity> : IBaseServices<TEntity> where TEntity : class, new()
    {
        public IBaseRepository<TEntity> baseRepository;

        public async Task<TEntity> QueryById(object id)
        {
            return await baseRepository.QueryById(id);
        }

        public async Task<List<TEntity>> QueryByIds(object[] ids)
        {
            return await baseRepository.QueryByIds(ids);
        }

        public async Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression)
        {
            return await baseRepository.Query(whereExpression);
        }

        public async Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, Expression<Func<TEntity, object>> orderExpression, bool isAsc)
        {
            return await baseRepository.Query(whereExpression, orderExpression, isAsc);
        }

        public async Task<int> Add(TEntity entity)
        {
            return await baseRepository.Add(entity);
        }

        public async Task<int> Add(List<TEntity> entities)
        {
            return await baseRepository.Add(entities);
        }

        public async Task<bool> DeleteById(object id)
        {
            return await baseRepository.DeleteById(id);
        }

        public async Task<bool> DeleteByModel(TEntity entity)
        {
            return await baseRepository.DeleteByModel(entity);
        }

        public async Task<bool> DeleteByIds(List<object> ids)
        {
            return await baseRepository.DeleteByIds(ids);
        }

        public async Task<bool> Update(TEntity entity)
        {
            return await baseRepository.Update(entity);
        }
    }
}