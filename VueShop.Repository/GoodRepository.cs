using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
using VueShop.IRepository;
using VueShop.Model.DBModels;

namespace VueShop.Repository
{
    public class GoodRepository : BaseRepository<sp_goods>, IGoodRepository
    {
        public GoodRepository(ISqlSugarClient sqlSugarClient) : base(sqlSugarClient)
        {
        }
    }
}