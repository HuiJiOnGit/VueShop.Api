using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///快递表
    ///</summary>
    [SugarTable("sp_express")]
    public partial class sp_express
    {
        public sp_express()
        {
        }

        /// <summary>
        /// Desc:主键id
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int express_id { get; set; }

        /// <summary>
        /// Desc:订单id
        /// Default:
        /// Nullable:False
        /// </summary>
        public int order_id { get; set; }

        /// <summary>
        /// Desc:订单快递公司名称
        /// Default:
        /// Nullable:True
        /// </summary>
        public string express_com { get; set; }

        /// <summary>
        /// Desc:快递单编号
        /// Default:
        /// Nullable:True
        /// </summary>
        public string express_nu { get; set; }

        /// <summary>
        /// Desc:记录生成时间
        /// Default:
        /// Nullable:False
        /// </summary>
        public int create_time { get; set; }

        /// <summary>
        /// Desc:记录修改时间
        /// Default:
        /// Nullable:False
        /// </summary>
        public int update_time { get; set; }
    }
}