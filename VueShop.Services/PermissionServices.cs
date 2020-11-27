using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    public class PermissionServices : BaseServices<sp_permission>, IPermissionServices
    {
        private readonly IBaseRepository<sp_permission> _permissionRepository;

        public PermissionServices(IBaseRepository<sp_permission> permissionRepository)
        {
            base.baseRepository = permissionRepository;
            _permissionRepository = permissionRepository;
        }
    }
}