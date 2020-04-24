using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
using VueShop.IRepository;
using VueShop.Model.DBModels;

namespace VueShop.Repository
{
    public class OrderRepository : BaseRepository<sp_order>, IOrderRepository
    {
        public OrderRepository(ISqlSugarClient sqlSugarClient) : base(sqlSugarClient)
        {
        }
    }
}