using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sp_goods_cats")]
    public partial class sp_goods_cats
    {
        public sp_goods_cats()
        {
        }

        /// <summary>
        /// Desc:分类id
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int cat_id { get; set; }

        /// <summary>
        /// Desc:父级id
        /// Default:
        /// Nullable:False
        /// </summary>
        public int parent_id { get; set; }

        /// <summary>
        /// Desc:分类名称
        /// Default:
        /// Nullable:False
        /// </summary>
        public string cat_name { get; set; }

        /// <summary>
        /// Desc:是否显示
        /// Default:1
        /// Nullable:False
        /// </summary>
        public byte is_show { get; set; }

        /// <summary>
        /// Desc:分类排序
        /// Default:0
        /// Nullable:False
        /// </summary>
        public int cat_sort { get; set; }

        /// <summary>
        /// Desc:数据标记
        /// Default:1
        /// Nullable:False
        /// </summary>
        public byte data_flag { get; set; }

        /// <summary>
        /// Desc:创建时间
        /// Default:
        /// Nullable:False
        /// </summary>
        public int create_time { get; set; }
    }
}