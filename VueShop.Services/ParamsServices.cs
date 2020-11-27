using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    public class ParamsServices : BaseServices<sp_attribute>, IParamsServices
    {
        private readonly IBaseRepository<sp_attribute> _paramsRepository;

        public ParamsServices(IBaseRepository<sp_attribute> paramsRepository)
        {
            base.baseRepository = paramsRepository;
            _paramsRepository = paramsRepository;
        }
    }
}