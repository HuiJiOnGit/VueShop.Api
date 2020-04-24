using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    public class CateServices : BaseServices<sp_category>, ICateServices
    {
        private ICateRepository CateRepository;

        public CateServices(ICateRepository cateRepository)
        {
            this.CateRepository = cateRepository;
            base.baseRepository = cateRepository;
        }
    }
}