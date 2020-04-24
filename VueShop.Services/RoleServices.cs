using System;
using System.Collections.Generic;
using System.Text;
using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    public class RoleServices : BaseServices<sp_role>, IRoleServices
    {
        private IRoleRepository roleRepository;

        public RoleServices(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
            base.baseRepository = roleRepository;
        }
    }
}