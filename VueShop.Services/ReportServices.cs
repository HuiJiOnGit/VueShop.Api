using System;
using System.Collections.Generic;
using System.Text;
using VueShop.IRepository;
using VueShop.IServices;
using VueShop.Model.DBModels;

namespace VueShop.Services
{
    public class ReportServices : BaseServices<sp_report_1>, IReportServices
    {
        private readonly IBaseRepository<sp_report_1> _reportRepository;

        public ReportServices(IBaseRepository<sp_report_1> reportRepository)
        {
            base.baseRepository = reportRepository;
            _reportRepository = reportRepository;
        }
    }
}