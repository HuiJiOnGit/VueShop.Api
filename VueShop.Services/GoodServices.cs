using System;
using System.Collections.Generic;
using System.Text;
using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    public class GoodServices : BaseServices<sp_goods>, IGoodServices
    {
        private IGoodRepository goodRepository;

        public GoodServices(IGoodRepository goodRepository)
        {
            this.goodRepository = goodRepository;
            base.baseRepository = goodRepository;
        }
    }
}