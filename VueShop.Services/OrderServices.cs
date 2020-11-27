using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    internal class OrderServices : BaseServices<sp_order>, IOrderServices
    {
        private readonly IBaseRepository<sp_order> _orderRepository;

        public OrderServices(IBaseRepository<sp_order> orderRepository)
        {
            base.baseRepository = orderRepository;
            _orderRepository = orderRepository;
        }
    }
}