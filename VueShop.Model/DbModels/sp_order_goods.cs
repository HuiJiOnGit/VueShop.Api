using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///商品订单关联表
    ///</summary>
    [SugarTable("sp_order_goods")]
    public partial class sp_order_goods
    {
        public sp_order_goods()
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
        /// Desc:订单id
        /// Default:
        /// Nullable:False
        /// </summary>
        public int order_id { get; set; }

        /// <summary>
        /// Desc:商品id
        /// Default:
        /// Nullable:False
        /// </summary>
        public int goods_id { get; set; }

        /// <summary>
        /// Desc:商品单价
        /// Default:0.00
        /// Nullable:False
        /// </summary>
        public decimal goods_price { get; set; }

        /// <summary>
        /// Desc:购买单个商品数量
        /// Default:1
        /// Nullable:False
        /// </summary>
        public byte goods_number { get; set; }

        /// <summary>
        /// Desc:商品小计价格
        /// Default:0.00
        /// Nullable:False
        /// </summary>
        public decimal goods_total_price { get; set; }
    }
}