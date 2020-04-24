using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///收货人表
    ///</summary>
    [SugarTable("sp_consignee")]
    public partial class sp_consignee
    {
        public sp_consignee()
        {
        }

        /// <summary>
        /// Desc:主键id
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int cgn_id { get; set; }

        /// <summary>
        /// Desc:会员id
        /// Default:
        /// Nullable:False
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Desc:收货人名称
        /// Default:
        /// Nullable:False
        /// </summary>
        public string cgn_name { get; set; }

        /// <summary>
        /// Desc:收货人地址
        /// Default:
        /// Nullable:False
        /// </summary>
        public string cgn_address { get; set; }

        /// <summary>
        /// Desc:收货人电话
        /// Default:
        /// Nullable:False
        /// </summary>
        public string cgn_tel { get; set; }

        /// <summary>
        /// Desc:邮编
        /// Default:
        /// Nullable:False
        /// </summary>
        public string cgn_code { get; set; }

        /// <summary>
        /// Desc:删除时间
        /// Default:
        /// Nullable:True
        /// </summary>
        public int? delete_time { get; set; }
    }
}