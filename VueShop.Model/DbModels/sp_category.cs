using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sp_category")]
    public partial class sp_category
    {
        public sp_category()
        {
        }

        /// <summary>
        /// Desc:分类唯一ID
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int cat_id { get; set; }

        /// <summary>
        /// Desc:分类名称
        /// Default:
        /// Nullable:True
        /// </summary>
        public string cat_name { get; set; }

        /// <summary>
        /// Desc:分类父ID
        /// Default:
        /// Nullable:True
        /// </summary>
        public int? cat_pid { get; set; }

        /// <summary>
        /// Desc:分类层级 0: 顶级 1:二级 2:三级
        /// Default:
        /// Nullable:True
        /// </summary>
        public int? cat_level { get; set; }

        /// <summary>
        /// Desc:是否删除 1为删除
        /// Default:0
        /// Nullable:True
        /// </summary>
        public int? cat_deleted { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public string cat_icon { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public string cat_src { get; set; }
    }
}