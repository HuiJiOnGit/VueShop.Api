using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
using VueShop.IRepository;
using VueShop.Model.DBModels;

namespace VueShop.Repository
{
    public class ParamsRepository : BaseRepository<sp_attribute>, IParamsRepository
    {
        public ParamsRepository(ISqlSugarClient sqlSugarClient) : base(sqlSugarClient)
        {
        }
    }
}