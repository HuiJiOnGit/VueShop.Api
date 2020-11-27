using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    public class CateServices : BaseServices<sp_category>, ICateServices
    {
        private readonly IBaseRepository<sp_category> _cateRepository;

        public CateServices(IBaseRepository<sp_category> cateRepository)
        {

            base.baseRepository = cateRepository;
            _cateRepository = cateRepository;
        }
    }
}