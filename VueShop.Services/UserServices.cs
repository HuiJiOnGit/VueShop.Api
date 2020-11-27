using System;
using System.Linq;
using System.Threading.Tasks;
using VueShop.Common.Helper;
using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;
using VueShop.Model.ViewModels;

namespace VueShop.Services
{
    public class UserServices : BaseServices<sp_manager>, IUserServices
    {
        private readonly IBaseRepository<sp_manager> _userRepository;

        public UserServices(IBaseRepository<sp_manager> userRepository)
        {
            base.baseRepository = userRepository;
            _userRepository = userRepository;
        }

        public async Task<LoginViewModel> GetUser(LoginViewModel loginViewModel)
        {
            var user = (await _userRepository.Query(n => n.mg_name == loginViewModel.UserName)).FirstOrDefault();

            if (user == null)
            {
                return null;
            }

            var result = new LoginViewModel
            {
                UserName = user.mg_name,
                Password = user.mg_pwd
            };

            var pwd = MD5Helper.MD5Encrypt32(loginViewModel.Password);
            Console.WriteLine(pwd);
            if (pwd == result.Password)
            {
                return result;
            }
            return null;
        }
    }
}