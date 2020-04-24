using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
using VueShop.IRepository;
using VueShop.Model.DBModels;

namespace VueShop.Repository
{
    public class ReportRepository : BaseRepository<sp_report_1>, IReportRepository
    {
        public ReportRepository(ISqlSugarClient sqlSugarClient) : base(sqlSugarClient)
        {
        }
    }
}