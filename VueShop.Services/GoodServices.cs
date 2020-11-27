using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    public class GoodServices : BaseServices<sp_goods>, IGoodServices
    {
        private readonly IBaseRepository<sp_goods> _goodRepository;

        public GoodServices(IBaseRepository<sp_goods> goodRepository)
        {
            base.baseRepository = goodRepository;
            _goodRepository = goodRepository;
        }
    }
}