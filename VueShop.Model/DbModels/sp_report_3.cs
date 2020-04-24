using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sp_report_3")]
    public partial class sp_report_3
    {
        public sp_report_3()
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
        /// Desc:用户来源
        /// Default:
        /// Nullable:True
        /// </summary>
        public string rp3_src { get; set; }

        /// <summary>
        /// Desc:数量
        /// Default:
        /// Nullable:True
        /// </summary>
        public int? rp3_count { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public DateTime? rp3_date { get; set; }
    }
}