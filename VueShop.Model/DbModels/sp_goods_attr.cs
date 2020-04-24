using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///商品-属性关联表
    ///</summary>
    [SugarTable("sp_goods_attr")]
    public partial class sp_goods_attr
    {
        public sp_goods_attr()
        {
        }

        /// <summary>
        /// Desc:主键id
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// Desc:商品id
        /// Default:
        /// Nullable:False
        /// </summary>
        public int goods_id { get; set; }

        /// <summary>
        /// Desc:属性id
        /// Default:
        /// Nullable:False
        /// </summary>
        public short attr_id { get; set; }

        /// <summary>
        /// Desc:商品对应属性的值
        /// Default:
        /// Nullable:False
        /// </summary>
        public string attr_value { get; set; }

        /// <summary>
        /// Desc:该属性需要额外增加的价钱
        /// Default:
        /// Nullable:True
        /// </summary>
        public decimal? add_price { get; set; }
    }
}