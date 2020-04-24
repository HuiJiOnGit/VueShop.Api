using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///商品-相册关联表
    ///</summary>
    [SugarTable("sp_goods_pics")]
    public partial class sp_goods_pics
    {
        public sp_goods_pics()
        {
        }

        /// <summary>
        /// Desc:主键id
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int pics_id { get; set; }

        /// <summary>
        /// Desc:商品id
        /// Default:
        /// Nullable:False
        /// </summary>
        public int goods_id { get; set; }

        /// <summary>
        /// Desc:相册大图800*800
        /// Default:
        /// Nullable:False
        /// </summary>
        public string pics_big { get; set; }

        /// <summary>
        /// Desc:相册中图350*350
        /// Default:
        /// Nullable:False
        /// </summary>
        public string pics_mid { get; set; }

        /// <summary>
        /// Desc:相册小图50*50
        /// Default:
        /// Nullable:False
        /// </summary>
        public string pics_sma { get; set; }
    }
}