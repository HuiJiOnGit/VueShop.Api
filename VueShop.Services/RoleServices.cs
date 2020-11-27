using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    public class RoleServices : BaseServices<sp_role>, IRoleServices
    {
        private readonly IBaseRepository<sp_role> _roleRepository;

        public RoleServices(IBaseRepository<sp_role> roleRepository)
        {
            base.baseRepository = roleRepository;
            _roleRepository = roleRepository;
        }
    }
}