using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sp_report_1")]
    public partial class sp_report_1
    {
        public sp_report_1()
        {
        }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// Desc:用户数
        /// Default:
        /// Nullable:True
        /// </summary>
        public int? rp1_user_count { get; set; }

        /// <summary>
        /// Desc:地区
        /// Default:
        /// Nullable:True
        /// </summary>
        public string rp1_area { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public DateTime? rp1_date { get; set; }
    }
}