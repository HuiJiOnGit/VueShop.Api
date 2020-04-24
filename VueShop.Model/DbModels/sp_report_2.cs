using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sp_report_2")]
    public partial class sp_report_2
    {
        public sp_report_2()
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
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public string rp2_page { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public int? rp2_count { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public DateTime? rp2_date { get; set; }
    }
}