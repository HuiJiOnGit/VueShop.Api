using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
using VueShop.IRepository;
using VueShop.Model.DBModels;

namespace VueShop.Repository
{
    public class UserRepository : BaseRepository<sp_user>, IUserRepository
    {
        public UserRepository(ISqlSugarClient sqlSugarClient) : base(sqlSugarClient)
        {
        }
    }
}