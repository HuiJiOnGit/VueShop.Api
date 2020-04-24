using System;
using System.Collections.Generic;
using System.Text;
using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    public class ParamsServices : BaseServices<sp_attribute>, IParamsServices
    {
        private readonly IParamsRepository paramsRepository;

        public ParamsServices(IParamsRepository paramsRepository)
        {
            base.baseRepository = paramsRepository;
            this.paramsRepository = paramsRepository;
        }
    }
}