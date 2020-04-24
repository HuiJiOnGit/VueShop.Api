using System;
using System.Collections.Generic;
using System.Text;
using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    public class UserServices : BaseServices<sp_user>, IUserServices
    {
        private IUserRepository userRepository;

        public UserServices(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
            base.baseRepository = userRepository;
        }
    }
}