using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///订单表
    ///</summary>
    [SugarTable("sp_order")]
    public partial class sp_order
    {
        public sp_order()
        {
        }

        /// <summary>
        /// Desc:主键id
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int order_id { get; set; }

        /// <summary>
        /// Desc:下订单会员id
        /// Default:
        /// Nullable:False
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Desc:订单编号
        /// Default:
        /// Nullable:False
        /// </summary>
        public string order_number { get; set; }

        /// <summary>
        /// Desc:订单总金额
        /// Default:0.00
        /// Nullable:False
        /// </summary>
        public decimal order_price { get; set; }

        /// <summary>
        /// Desc:支付方式  0未支付 1支付宝  2微信  3银行卡
        /// Default:1
        /// Nullable:False
        /// </summary>
        public string order_pay { get; set; }

        /// <summary>
        /// Desc:订单是否已经发货
        /// Default:否
        /// Nullable:False
        /// </summary>
        public string is_send { get; set; }

        /// <summary>
        /// Desc:支付宝交易流水号码
        /// Default:
        /// Nullable:False
        /// </summary>
        public string trade_no { get; set; }

        /// <summary>
        /// Desc:发票抬头 个人 公司
        /// Default:个人
        /// Nullable:False
        /// </summary>
        public string order_fapiao_title { get; set; }

        /// <summary>
        /// Desc:公司名称
        /// Default:
        /// Nullable:False
        /// </summary>
        public string order_fapiao_company { get; set; }

        /// <summary>
        /// Desc:发票内容
        /// Default:
        /// Nullable:False
        /// </summary>
        public string order_fapiao_content { get; set; }

        /// <summary>
        /// Desc:consignee收货人地址
        /// Default:
        /// Nullable:False
        /// </summary>
        public string consignee_addr { get; set; }

        /// <summary>
        /// Desc:订单状态： 0未付款、1已付款
        /// Default:0
        /// Nullable:False
        /// </summary>
        public string pay_status { get; set; }

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