using VueShop.Model.DBModels;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VueShop.IRepository;

namespace VueShop.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        private readonly ISqlSugarClient _sqlSugarClient;
        private readonly IUnitOfWork _unitOfWork;
        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _sqlSugarClient = unitOfWork.GetDbClient();
            //调式代码 用来打印SQL
            Db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" +
                    Db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };
            _unitOfWork = unitOfWork;
        }

        //注意：不能写成静态的
        //用来处理事务多表查询和复杂的操作
        public SqlSugarClient Db
        {
            get
            {
                return _sqlSugarClient as SqlSugarClient;
            }
        }


        #region 表属性

        public SimpleClient<T> CurrentDb { get { return new SimpleClient<T>(Db); } }//用来操作当前表的数据

        public SimpleClient<sp_attribute> sp_attributeDb { get { return new SimpleClient<sp_attribute>(Db); } }//用来处理sp_attribute表的常用操作
        public SimpleClient<sp_category> sp_categoryDb { get { return new SimpleClient<sp_category>(Db); } }//用来处理sp_category表的常用操作
        public SimpleClient<sp_consignee> sp_consigneeDb { get { return new SimpleClient<sp_consignee>(Db); } }//用来处理sp_consignee表的常用操作
        public SimpleClient<sp_express> sp_expressDb { get { return new SimpleClient<sp_express>(Db); } }//用来处理sp_express表的常用操作
        public SimpleClient<sp_goods> sp_goodsDb { get { return new SimpleClient<sp_goods>(Db); } }//用来处理sp_goods表的常用操作
        public SimpleClient<sp_goods_attr> sp_goods_attrDb { get { return new SimpleClient<sp_goods_attr>(Db); } }//用来处理sp_goods_attr表的常用操作
        public SimpleClient<sp_goods_cats> sp_goods_catsDb { get { return new SimpleClient<sp_goods_cats>(Db); } }//用来处理sp_goods_cats表的常用操作
        public SimpleClient<sp_goods_pics> sp_goods_picsDb { get { return new SimpleClient<sp_goods_pics>(Db); } }//用来处理sp_goods_pics表的常用操作
        public SimpleClient<sp_manager> sp_managerDb { get { return new SimpleClient<sp_manager>(Db); } }//用来处理sp_manager表的常用操作
        public SimpleClient<sp_order> sp_orderDb { get { return new SimpleClient<sp_order>(Db); } }//用来处理sp_order表的常用操作
        public SimpleClient<sp_order_goods> sp_order_goodsDb { get { return new SimpleClient<sp_order_goods>(Db); } }//用来处理sp_order_goods表的常用操作
        public SimpleClient<sp_permission> sp_permissionDb { get { return new SimpleClient<sp_permission>(Db); } }//用来处理sp_permission表的常用操作
        public SimpleClient<sp_permission_api> sp_permission_apiDb { get { return new SimpleClient<sp_permission_api>(Db); } }//用来处理sp_permission_api表的常用操作
        public SimpleClient<sp_report_1> sp_report_1Db { get { return new SimpleClient<sp_report_1>(Db); } }//用来处理sp_report_1表的常用操作
        public SimpleClient<sp_report_2> sp_report_2Db { get { return new SimpleClient<sp_report_2>(Db); } }//用来处理sp_report_2表的常用操作
        public SimpleClient<sp_report_3> sp_report_3Db { get { return new SimpleClient<sp_report_3>(Db); } }//用来处理sp_report_3表的常用操作
        public SimpleClient<sp_role> sp_roleDb { get { return new SimpleClient<sp_role>(Db); } }//用来处理sp_role表的常用操作
        public SimpleClient<sp_type> sp_typeDb { get { return new SimpleClient<sp_type>(Db); } }//用来处理sp_type表的常用操作
        public SimpleClient<sp_user> sp_userDb { get { return new SimpleClient<sp_user>(Db); } }//用来处理sp_user表的常用操作
        public SimpleClient<sp_user_cart> sp_user_cartDb { get { return new SimpleClient<sp_user_cart>(Db); } }//用来处理sp_user_cart表的常用操作

        #endregion 表属性

        #region 方法

        /// <summary>
        /// 根据id查询一个数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> QueryById(object id)
        {
            return await Db.Queryable<T>().In(id).SingleAsync();
        }

        /// <summary>
        /// 根据id数组查询多个数据
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<List<T>> QueryByIds(object[] ids)
        {
            return await Db.Queryable<T>().In(ids).ToListAsync();
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="whereExpression"></param>
        /// <returns></returns>
        public async Task<List<T>> Query(Expression<Func<T, bool>> whereExpression)
        {
            return await Db.Queryable<T>().WhereIF(whereExpression != null, whereExpression).ToListAsync();
        }

        /// <summary>
        /// 根据条件刷选数据并排序
        /// </summary>
        /// <param name="whereExpression"></param>
        /// <param name="orderExpression"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        public async Task<List<T>> Query(Expression<Func<T, bool>> whereExpression, Expression<Func<T, object>> orderExpression, bool isAsc)
        {
            return await Db.Queryable<T>().OrderByIF(orderExpression != null, orderExpression, isAsc ? OrderByType.Asc : OrderByType.Desc).WhereIF(whereExpression != null, whereExpression).ToListAsync();
        }

        /// <summary>
        /// 根据实体添加数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> Add(T entity)
        {
            return await Db.Insertable(entity).ExecuteCommandAsync();
        }

        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task<int> Add(List<T> entities)
        {
            return await Db.Insertable(entities.ToArray()).ExecuteCommandAsync();
        }

        /// <summary>
        /// 根据id删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteById(object id)
        {
            return await Db.Deleteable<T>(id).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 根据model删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> DeleteByModel(T entity)
        {
            return await Db.Deleteable(entity).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<bool> DeleteByIds(List<object> ids)
        {
            return await Db.Deleteable<T>().In(ids).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        /// 根据实体更新数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> Update(T entity)
        {
            return await Db.Updateable(entity).ExecuteCommandHasChangeAsync();
        }

        #endregion 方法
    }
}