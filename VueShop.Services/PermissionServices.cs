using System;
using System.Collections.Generic;
using System.Text;
using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    public class PermissionServices : BaseServices<sp_permission>, IPermissionServices
    {
        private IPermissionRepository permissionRepository;

        public PermissionServices(IPermissionRepository permissionRepository)
        {
            this.permissionRepository = permissionRepository;
            base.baseRepository = permissionRepository;
        }
    }
}