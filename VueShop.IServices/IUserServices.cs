using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VueShop.Model.DBModels;
using VueShop.Model.ViewModels;

namespace VueShop.IServices
{
    public interface IUserServices : IBaseServices<sp_manager>
    {
        Task<LoginViewModel> GetUser(LoginViewModel loginViewModel);
    }
}