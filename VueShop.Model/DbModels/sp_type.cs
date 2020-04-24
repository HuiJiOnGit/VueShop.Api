using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///类型表
    ///</summary>
    [SugarTable("sp_type")]
    public partial class sp_type
    {
        public sp_type()
        {
        }

        /// <summary>
        /// Desc:主键id
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public short type_id { get; set; }

        /// <summary>
        /// Desc:类型名称
        /// Default:
        /// Nullable:False
        /// </summary>
        public string type_name { get; set; }

        /// <summary>
        /// Desc:删除时间标志
        /// Default:
        /// Nullable:True
        /// </summary>
        public int? delete_time { get; set; }
    }
}