using System;
using System.Collections.Generic;
using System.Text;
using VueShop.Model.DBModels;

namespace VueShop.IRepository
{
    public interface IOrderRepository : IBaseRepository<sp_order>
    {
    }
}