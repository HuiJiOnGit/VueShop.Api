using System;
using System.Collections.Generic;
using System.Text;
using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    internal class OrderServices : BaseServices<sp_order>, IOrderServices
    {
        private IOrderRepository orderRepository;

        public OrderServices(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
            base.baseRepository = orderRepository;
        }
    }
}