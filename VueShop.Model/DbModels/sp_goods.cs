using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///商品表
    ///</summary>
    [SugarTable("sp_goods")]
    public partial class sp_goods
    {
        public sp_goods()
        {
        }

        /// <summary>
        /// Desc:主键id
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int goods_id { get; set; }

        /// <summary>
        /// Desc:商品名称
        /// Default:
        /// Nullable:False
        /// </summary>
        public string goods_name { get; set; }

        /// <summary>
        /// Desc:商品价格
        /// Default:0.00
        /// Nullable:False
        /// </summary>
        public decimal goods_price { get; set; }

        /// <summary>
        /// Desc:商品数量
        /// Default:0
        /// Nullable:False
        /// </summary>
        public int goods_number { get; set; }

        /// <summary>
        /// Desc:商品重量
        /// Default:0
        /// Nullable:False
        /// </summary>
        public short goods_weight { get; set; }

        /// <summary>
        /// Desc:类型id
        /// Default:0
        /// Nullable:False
        /// </summary>
        public short cat_id { get; set; }

        /// <summary>
        /// Desc:商品详情介绍
        /// Default:
        /// Nullable:True
        /// </summary>
        public string goods_introduce { get; set; }

        /// <summary>
        /// Desc:图片logo大图
        /// Default:
        /// Nullable:False
        /// </summary>
        public string goods_big_logo { get; set; }

        /// <summary>
        /// Desc:图片logo小图
        /// Default:
        /// Nullable:False
        /// </summary>
        public string goods_small_logo { get; set; }

        /// <summary>
        /// Desc:0:正常  1:删除
        /// Default:0
        /// Nullable:False
        /// </summary>
        public string is_del { get; set; }

        /// <summary>
        /// Desc:添加商品时间
        /// Default:
        /// Nullable:False
        /// </summary>
        public int add_time { get; set; }

        /// <summary>
        /// Desc:修改商品时间
        /// Default:
        /// Nullable:False
        /// </summary>
        public int upd_time { get; set; }

        /// <summary>
        /// Desc:软删除标志字段
        /// Default:
        /// Nullable:True
        /// </summary>
        public int? delete_time { get; set; }

        /// <summary>
        /// Desc:一级分类id
        /// Default:0
        /// Nullable:True
        /// </summary>
        public short? cat_one_id { get; set; }

        /// <summary>
        /// Desc:二级分类id
        /// Default:0
        /// Nullable:True
        /// </summary>
        public short? cat_two_id { get; set; }

        /// <summary>
        /// Desc:三级分类id
        /// Default:0
        /// Nullable:True
        /// </summary>
        public short? cat_three_id { get; set; }

        /// <summary>
        /// Desc:热卖数量
        /// Default:0
        /// Nullable:True
        /// </summary>
        public int? hot_mumber { get; set; }

        /// <summary>
        /// Desc:是否促销
        /// Default:0
        /// Nullable:True
        /// </summary>
        public short? is_promote { get; set; }

        /// <summary>
        /// Desc:商品状态 0: 未通过 1: 审核中 2: 已审核
        /// Default:0
        /// Nullable:True
        /// </summary>
        public int? goods_state { get; set; }
    }
}