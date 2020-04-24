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
        private IReportRepository reportRepository;

        public ReportServices(IReportRepository reportRepository)
        {
            this.reportRepository = reportRepository;
            base.baseRepository = reportRepository;
        }
    }
}